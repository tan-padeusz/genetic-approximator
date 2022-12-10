using System.Text;

namespace GeneticApproximator;

/// <summary>
/// Class that represents single Individual.
/// </summary>
public class Individual
{
    /// <summary>
    /// Individual random number generator.
    /// </summary>
    private static Random Random { get; } = new Random();
    
    /// <summary>
    /// Individual error.
    /// </summary>
    public double Error { get; }
    
    /// <summary>
    /// Individual factors used in it's polynomial.
    /// </summary>
    public double[,] Factors { get; }
    
    /// <summary>
    /// Individual genes.
    /// </summary>
    public GeneSequence GeneSequence { get; }

    /// <summary>
    /// Creates new individual with random genes.
    /// </summary>
    /// <param name="points">Array of input points.</param>
    public Individual(Point[] points)
    {
        this.GeneSequence = new GeneSequence();
        this.Factors = this.DecodeGenes();
        this.Error = this.CalculateAveragePointError(points);
    }

    /// <summary>
    /// Creates new offspring Individual.
    /// </summary>
    /// <param name="points">Array of input Points.</param>
    /// <param name="parents">Parents of new Individual.</param>
    public Individual(Point[] points, Individual[] parents)
    {
        this.GeneSequence = new GeneSequence(parents);
        this.Factors = this.DecodeGenes();
        this.Error = this.CalculateAveragePointError(points);
    }

    /// <summary>
    /// Converts Individual genes into Individual polynomial factors.
    /// </summary>
    /// <returns>Two-dimensional array of Individual polynomial factors.</returns>
    private double[,] DecodeGenes()
    {
        int bitsPerFactor = InterfaceInputs.BitsPerFactor;
        int maxPolynomialDegree = InterfaceInputs.MaxPolynomialDegree;
        double[] axisValues = this.GenerateAxisValues();
        double[,] factors = new double[maxPolynomialDegree + 1, maxPolynomialDegree + 1];
        
        for (int xi = 0; xi <= maxPolynomialDegree; xi++) for (int yi = 0; yi <= maxPolynomialDegree; yi++)
        {
            double factor = 0;
            for (int gi = 0; gi < bitsPerFactor; gi++) if (this.GeneSequence[xi, yi, gi].Value) factor += axisValues[gi];
            factors[xi, yi] = factor / bitsPerFactor;
        }
        
        return factors;
    }

    /// <summary>
    /// Generates axis values.
    /// </summary>
    /// <returns>Array of axis values.</returns>
    private double[] GenerateAxisValues()
    {
        int bpf = InterfaceInputs.BitsPerFactor;
        double bv = InterfaceInputs.AxisBorderValue;
        double[] axisValues = new double[bpf];
        // start + (n - 1) * step = end => step = (end - start) / (n - 1)
        double step = (bv * 2) / (bpf - 1);
        axisValues[0] = -bv;
        for (int index = 1; index < bpf; index++) axisValues[index] = axisValues[index - 1] + step;
        return axisValues;
    }

    /// <summary>
    /// Calculates average error value for array of input points.
    /// <br/>
    /// This value also acts as result of objective function in genetic algorithm.
    /// </summary>
    /// <param name="points">Array of input points.</param>
    /// <returns>Average error value for given array of input points.</returns>
    private double CalculateAveragePointError(Point[] points)
    {
        double error = 0;
        foreach (Point point in points) error += this.CalculatePointError(point);
        return error / points.Length;
    }

    /// <summary>
    /// Calculates error value for single input point.
    /// </summary>
    /// <param name="point">Input point.</param>
    /// <returns>Error value for given input point.</returns>
    private double CalculatePointError(Point point)
    {
        int maxPolynomialDegree = InterfaceInputs.MaxPolynomialDegree;
        return Math.Pow(this.CalculateFunctionResult(point) - point.Z, 2); // Possible other metrics.
        double error = 0;
        for (int xi = 0; xi <= maxPolynomialDegree; xi++) for (int yi = 0; yi <= maxPolynomialDegree; yi++)
            error += this.Factors[xi, yi] * Math.Pow(point.X, xi) * Math.Pow(point.Y, yi);
        return Math.Pow(error - point.Z, 2); // Possible other metrics.
    }

    /// <summary>
    /// Calculates individual function result for given input point.
    /// </summary>
    /// <param name="point">Input point.</param>
    /// <returns>Function result for given input point.</returns>
    public double CalculateFunctionResult(Point point)
    {
        /*
        int maxPolynomialDegree = InterfaceInputs.MaxPolynomialDegree;
        double result = 0;
        for (int xi = 0; xi <= maxPolynomialDegree; xi++) for (int yi = 0; yi <= maxPolynomialDegree; yi++)
            result += this.Factors[xi, yi] * Math.Pow(point.X, xi) * Math.Pow(point.Y, yi);
        return result;
        */

        /*
        int mpd = InterfaceInputs.MaxPolynomialDegree;
        double result = 0;
        for (int i = 0; i < (mpd + 1) * (mpd + 1); i++)
        {
            int xi = i / (mpd + 1);
            int yi = i - xi * (mpd + 1);
            result += this.Factors[xi, yi] * Math.Pow(point.X, xi) * Math.Pow(point.Y, yi);
        }
        return result;
        */

        int mpd = InterfaceInputs.MaxPolynomialDegree;
        double result = 0;
        Parallel.For(0, (mpd + 1) * (mpd + 1), i =>
        {
            int xi = i / (mpd + 1);
            int yi = i - xi * (mpd + 1);
            result += this.Factors[xi, yi] * Math.Pow(point.X, xi) * Math.Pow(point.Y, yi);
        });
        return result;
    }

    public override string ToString()
    {
        StringBuilder builder = new StringBuilder();
        int maxPolynomialDegree = InterfaceInputs.MaxPolynomialDegree;
        for (int xi = 0; xi <= maxPolynomialDegree; xi++) for (int yi = 0; yi <= maxPolynomialDegree; yi++)
        {
            double factor = this.Factors[xi, yi];
            if (factor >= 0) builder.Append('+');
            builder.Append($"{factor}[{xi},{yi}]");
        }
        return builder.ToString();
    }
}