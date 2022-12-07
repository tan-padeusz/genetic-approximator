namespace GeneticApproximator;

public static class InterfaceInputs
{
    /// <summary>
    /// Maximum (absolute) value of axis that further determines polynomial factors values.
    /// </summary>
    public static double AxisBorderValue { get; set; } = 100;
    
    /// <summary>
    /// Number of bits per factor.
    /// </summary>
    public static int BitsPerFactor { get; set; } = 8;
    
    /// <summary>
    /// Number of contestants in contest.
    /// </summary>
    public static int Contestants { get; set; } = 10;

    /// <summary>
    /// Max degree of result polynomial.
    /// </summary>
    public static int MaxPolynomialDegree { get; set; } = 3;

    /// <summary>
    /// Probability of mutating a gene.
    /// </summary>
    public static double MutationProbability { get; set; } = 0.01;

    /// <summary>
    /// Array of input points.
    /// </summary>
    public static Point[] InputPoints { get; set; } = new Point[0];

    /// <summary>
    /// Number of individuals in each population.
    /// </summary>
    public static int PopulationSize { get; set; } = 100;
}