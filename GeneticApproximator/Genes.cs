namespace GeneticApproximator;

/// <summary>
/// Class that stores information about individual genes.
/// </summary>
public class Genes
{
    /// <summary>
    /// Genes random number generator.
    /// </summary>
    private static Random Random { get; } = new Random();
    
    /// <summary>
    /// Bool array of genes.
    /// </summary>
    private bool[] GeneArray { get; }

    /// <summary>
    /// Gets gene as in 1D array.
    /// </summary>
    /// <param name="gi">Gene index.</param>
    public bool this[int gi] => this.GeneArray[gi];
    
    /// <summary>
    /// Gets gene as in 3D array.
    /// </summary>
    /// <param name="xi">X degree.</param>
    /// <param name="yi">Y degree.</param>
    /// <param name="gi">Gene index.</param>
    public bool this[int xi, int yi, int gi] => this.GeneArray[(xi * (InterfaceInputs.MaxPolynomialDegree + 1) + yi) * InterfaceInputs.BitsPerFactor + gi];

    /// <summary>
    /// Generates random Individual genes.
    /// </summary>
    public Genes()
    {
        int size = (int)Math.Pow(InterfaceInputs.MaxPolynomialDegree + 1, 2) * InterfaceInputs.BitsPerFactor;
        this.GeneArray = new bool[size];
        for (int index = 0; index < size; index++) this.GeneArray[index] = Genes.Random.Next() % 2 == 1;
    }

    /// <summary>
    /// Generates offspring Individual genes.
    /// </summary>
    /// <param name="parents">Individual parents (pair of individuals).</param>
    public Genes(Parents parents)
    {
        int size = (int)Math.Pow(InterfaceInputs.MaxPolynomialDegree + 1, 2) * InterfaceInputs.BitsPerFactor;
        this.GeneArray = new bool[size];
        int divisionPointIndex = Genes.Random.Next(size - 1);
        for (int index = 0; index < size; index++)
        {
            Individual currentParent = index <= divisionPointIndex ? parents.First : parents.Second;
            this.GeneArray[index] = Genes.Random.NextDouble() < InterfaceInputs.MutationProbability ? currentParent.Genes[index] : !currentParent.Genes[index];
        }
    }
}