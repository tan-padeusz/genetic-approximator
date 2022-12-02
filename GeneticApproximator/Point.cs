using System.Runtime.CompilerServices;

namespace GeneticApproximator;

public class Point
{
    /// <summary>
    /// Point's random number generator.
    /// </summary>
    private static Random Random { get; } = new Random();

    /// <summary>
    /// Point's coordinates (0: X, 1:Y, 2:Z).
    /// </summary>
    private double[] Coordinates { get; } = new double[3];
    
    /// <summary>
    /// Point's X coordinate.
    /// </summary>
    public double X => this.Coordinates[0];
    
    /// <summary>
    /// Point's Y coordinate.
    /// </summary>
    public double Y => this.Coordinates[1];

    /// <summary>
    /// Point's Z coordinate.
    /// </summary>
    public double Z => this.Coordinates[2];

    /// <summary>
    /// Point's constructor.
    /// </summary>
    public Point()
    {
        for (int i = 0; i < 3; i++)
        {
            this.Coordinates[i] = Point.Random.Next() * InterfaceInputs.CoordinatesRange;
            if (this.ShouldBeNegative()) this.Coordinates[i] *= -1;
        }
    }

    /// <summary>
    /// Randomly indicates if coordinate should be negative.
    /// </summary>
    /// <returns>True if coordinate should be negative, false otherwise.</returns>
    private bool ShouldBeNegative()
    {
        return Point.Random.Next() % 2 == 1;
    }
}