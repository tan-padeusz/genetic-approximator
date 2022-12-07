namespace GeneticApproximator;

/// <summary>
/// Class representing input point.
/// </summary>
public class Point
{
    /// <summary>
    /// Point pseudo-random number generator.
    /// </summary>
    private static Random Random { get; } = new Random();

    /// <summary>
    /// Point coordinates.
    /// </summary>
    private double[] Coordinates { get; }
    
    /// <summary>
    /// Point X coordinate.
    /// </summary>
    public double X => this.Coordinates[0];
    
    /// <summary>
    /// Point Y coordinate.
    /// </summary>
    public double Y => this.Coordinates[1];

    /// <summary>
    /// Point Z coordinate.
    /// </summary>
    public double Z => this.Coordinates[2];

    /// <summary>
    /// Point constructor.
    /// </summary>
    public Point()
    {
        double[] coordinates = new double[3];
        for (int index = 0; index < coordinates.Length; index++)
        {
            double coordinate = Point.Random.NextDouble() * InterfaceInputs.CoordinatesRange;
            if (this.ShouldCoordinateBeNegative()) coordinate *= -1;
            coordinates[index] = coordinate;
        }
        this.Coordinates = coordinates;
    }

    /// <summary>
    /// Randomly indicates if coordinate should be negative.
    /// </summary>
    /// <returns>True if coordinate should be negative, false otherwise.</returns>
    private bool ShouldCoordinateBeNegative()
    {
        return Point.Random.Next() % 2 == 1;
    }

    public override string ToString()
    {
        return $"[{this.Coordinates[0]}, {this.Coordinates[1]}, {this.Coordinates[2]}]";
    }
}