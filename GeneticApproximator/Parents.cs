namespace GeneticApproximator;

/// <summary>
/// Container that stores two individuals that will become parents.
/// </summary>
public class Parents
{
    /// <summary>
    /// First parent individual.
    /// </summary>
    public Individual First { get; }
    
    /// <summary>
    /// Second parent individual.
    /// </summary>
    public Individual Second { get; }

    /// <summary>
    /// Parent's constructor.
    /// </summary>
    /// <param name="first">First parent.</param>
    /// <param name="second">Second parent.</param>
    public Parents(Individual first, Individual second)
    {
        this.First = first;
        this.Second = second;
    }
}