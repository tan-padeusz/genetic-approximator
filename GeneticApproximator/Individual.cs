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
    /// Creates new, random Individual.
    /// </summary>
    /// <param name="points">Array of input Points.</param>
    public Individual(Point[] points)
    {
        this.GeneSequence = new GeneSequence();
        this.Factors = this.DecodeGenes();
        this.Error = this.CalculateError(points);
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
        this.Error = this.CalculateError(points);
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
        double bv = InterfaceInputs.BorderValue;
        double[] axisValues = new double[bpf];
        // start + (n - 1) * step = end => step = (end - start) / (n - 1)
        double step = (bv * 2) / (bpf - 1);
        axisValues[0] = -bv;
        for (int index = 1; index < bpf; index++) axisValues[index] = axisValues[index - 1] + step;
        return axisValues;
    }

    /// <summary>
    /// Calculates Individual Error.
    /// </summary>
    /// <param name="points">Array of input Points.</param>
    /// <returns>Individual Error value.</returns>
    private double CalculateError(Point[] points)
    {
        double error = 0;
        foreach (Point point in points)
        {
            double partialError = 0;
            for (int xi = 0; xi <= InterfaceInputs.MaxPolynomialDegree; xi++)
            for (int yi = 0; yi <= InterfaceInputs.MaxPolynomialDegree; yi++)
                partialError += this.Factors[xi, yi] * Math.Pow(point.X, xi) * Math.Pow(point.Y, yi);
            error += Math.Pow(partialError - point.Z, 2);
        }
        return error / points.Length;
    }
}