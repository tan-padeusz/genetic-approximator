namespace GeneticApproximator;

/// <summary>
/// <see cref="Individual">Individual</see> <see cref="Gene">gene</see> sequence.
/// </summary>
public class GeneSequence
{
    /// <summary>
    /// GeneSequence pseudo-random number generator.
    /// </summary>
    private static Random Random { get; } = new Random();
    
    /// <summary>
    /// Array of genes.
    /// </summary>
    private Gene[] Genes { get; }

    /// <summary>
    /// Gets single gene.
    /// <br/>
    /// Gene sequence acts like one-dimensional array.
    /// </summary>
    /// <param name="gi">Gene index.</param>
    public Gene this[int gi] => this.Genes[gi];
    
    /// <summary>
    /// Gets single gene.
    /// <br/>
    /// Gene sequence acts like three-dimensional array.
    /// </summary>
    /// <param name="xi">X index.</param>
    /// <param name="yi">Y index.</param>
    /// <param name="gi">Gene index.</param>
    public Gene this[int xi, int yi, int gi] => this.Genes[(xi * (InterfaceInputs.MaxPolynomialDegree + 1) + yi) * InterfaceInputs.BitsPerFactor + gi];

    /// <summary>
    /// Creates new gene sequence filled with random genes.
    /// </summary>
    public GeneSequence()
    {
        int size = (int)Math.Pow(InterfaceInputs.MaxPolynomialDegree + 1, 2) * InterfaceInputs.BitsPerFactor;
        Gene[] genes = new Gene[size];
        for (int index = 0; index < size; index++) genes[index] = new Gene();
        this.Genes = genes;
    }

    /// <summary>
    /// Creates new gene sequence for offspring <see cref="Individual">individual</see>.
    /// </summary>
    /// <param name="parents">Individual parents.</param>
    public GeneSequence(Individual[] parents)
    {
        int size = (int)Math.Pow(InterfaceInputs.MaxPolynomialDegree + 1, 2) * InterfaceInputs.BitsPerFactor;
        Gene[] genes = new Gene[size];
        int divisionPointIndex = GeneSequence.Random.Next(size - 1);
        for (int index = 0; index < size; index++)
        {
            Individual currentParent = index <= divisionPointIndex ? parents[0] : parents[1];
            bool geneValue = GeneSequence.Random.NextDouble() < InterfaceInputs.MutationProbability
                ? currentParent.GeneSequence[index].Value
                : !currentParent.GeneSequence[index].Value;
            genes[index] = new Gene(geneValue);
        }
        this.Genes = genes;
    }
}