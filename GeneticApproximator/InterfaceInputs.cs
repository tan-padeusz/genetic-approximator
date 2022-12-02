namespace GeneticApproximator;

public static class InterfaceInputs
{
    /// <summary>
    /// Number of bits per factor.
    /// </summary>
    public static int BitsPerFactor { get; set; } = 8;

    /// <summary>
    /// Maximum 
    /// </summary>
    public static double BorderValue { get; set; } = 100;
    
    /// <summary>
    /// Number of contestants in contest.
    /// </summary>
    public static int Contestants { get; set; } = 10;

    /// <summary>
    /// Maximum absolute value of input points coordinates.
    /// </summary>
    public static double CoordinatesRange { get; set; } = 1000;

    /// <summary>
    /// Number of input points.
    /// </summary>
    public static int Points { get; set; } = 100;

    /// <summary>
    /// Max degree of result polynomial.
    /// </summary>
    public static int MaxPolynomialDegree { get; set; } = 3;

    /// <summary>
    /// Probability of mutating a gene.
    /// </summary>
    public static double MutationProbability { get; set; } = 0.01;

    /// <summary>
    /// Number of individuals in each population.
    /// </summary>
    public static int PopulationSize { get; set; } = 100;
}