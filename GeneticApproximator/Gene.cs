namespace GeneticApproximator;

/// <summary>
/// Single gene in <see cref="GeneSequence">gene sequence</see> of <see cref="Individual">individual</see>.
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
    public bool Value { get; }

    /// <summary>
    /// Creates new gene with random value.
    /// </summary>
    public Gene()
    {
        this.Value = Gene.Random.Next() % 2 == 1;
    }

    /// <summary>
    /// Creates new gene with specified value.
    /// </summary>
    /// <param name="value">Gene value.</param>
    public Gene(bool value)
    {
        this.Value = value;
    }
}