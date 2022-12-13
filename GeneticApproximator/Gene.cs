namespace GeneticApproximator;

/// <summary>
/// Single gene in gene sequence of individual.
/// </summary>
public class Gene
{
    /// <summary>
    /// Gene pseudo-random number generator.
    /// </summary>
    private static Random Random { get; } = new Random();
    
    /// <summary>
    /// Gene value.
    /// </summary>
    private bool Value { get; }

    /// <summary>
    /// Creates new gene with random value.
    /// </summary>
    private Gene()
    {
        this.Value = Gene.Random.Next() % 2 == 1;
    }

    /// <summary>
    /// Creates new gene with specified value.
    /// </summary>
    /// <param name="value">Gene value.</param>
    private Gene(bool value)
    {
        this.Value = value;
    }

    /// <summary>
    /// Creates new gene with same value as this gene.
    /// </summary>
    /// <returns>New gene.</returns>
    public Gene Same()
    {
        return new Gene(this.Value);
    }

    /// <summary>
    /// Creates new gene with opposite value to this gene.
    /// </summary>
    /// <returns>New gene.</returns>
    public Gene Opposite()
    {
        return new Gene(!this.Value);
    }

    public static bool operator true(Gene gene)
    {
        return gene.Value;
    }

    public static bool operator false(Gene gene)
    {
        return !gene.Value;
    }

    /// <summary>
    /// Generates array of genes with random values.
    /// </summary>
    /// <param name="size">Array size.</param>
    /// <returns>Array of genes.</returns>
    public static Gene[] GenerateGenes(int size)
    {
        Gene[] genes = new Gene[size];
        for (int index = 0; index < size; index++) genes[index] = new Gene();
        return genes;
    }
}