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
    private double Error { get; }
    
    /// <summary>
    /// Individual factors used in it's polynomial.
    /// </summary>
    private double[,] Factors { get; }
    
    /// <summary>
    /// Individual genes.
    /// </summary>
    private bool[] Genes { get; }

    /// <summary>
    /// Creates new, random Individual.
    /// </summary>
    /// <param name="points">Array of input Points.</param>
    public Individual(Point[] points)
    {
        this.Genes = this.GenerateGenes();
        this.Factors = new double[InterfaceInputs.PolynomialDegree + 1, InterfaceInputs.PolynomialDegree + 1];
    }

    /// <summary>
    /// Creates new Individual as offspring of two other Individuals.
    /// </summary>
    /// <param name="points">Array of input Points.</param>
    /// <param name="parents">Parents of new Individual.</param>
    public Individual(Point[] points, Parents parents)
    {
        
    }

    private bool[] GenerateGenes()
    {
        int size = InterfaceInputs.BitsPerFactor * (int)Math.Pow(InterfaceInputs.PolynomialDegree + 1, 2);
        bool[] genes = new bool[size];
        for (int index = 0; index < size; index++) genes[index] = Individual.Random.Next() % 2 == 1;
        return genes;
    }

    /// <summary>
    /// Converts Individual genes into Individual polynomial factors.
    /// </summary>
    /// <returns>Two-dimensional array of Individual polynomial factors.</returns>
    private double[,] DecodeGenes()
    {
        int bpf = InterfaceInputs.BitsPerFactor;
        int pd = InterfaceInputs.PolynomialDegree;
        double[] av = this.GenerateAxisValues();
        double[,] factors = new double[pd + 1, pd + 1];
        
        for (int xd = 0; xd <= pd; xd++) for (int yd = 0; yd <= pd; yd++)
        {
            double factor = 0;
            int sgi = (xd * (pd + 1) + yd) * bpf; // sgi = starting gene index
            for (int cgi = sgi; cgi < sgi + bpf; cgi++) // cgi = current gene index
            {
                int currentAxisValueIndex = cgi % bpf;
                if (this.Genes[cgi]) factor += av[currentAxisValueIndex];
            }
            factors[xd, yd] = factor / bpf;
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
}