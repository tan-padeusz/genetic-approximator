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
    public Point(double range)
    {
        double[] coordinates = new double[3];
        for (int index = 0; index < coordinates.Length; index++)
        {
            double coordinate = Point.Random.NextDouble() * range;
            if (this.ShouldCoordinateBeNegative()) coordinate *= -1;
            coordinates[index] = coordinate;
        }

        this.Coordinates = coordinates;
    }

    private Point(double x, double y, double z)
    {
        double[] coordinates = new double[] { x, y, z };
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

    public static Point[] GetTestPoints()
    {
        return new Point[]
        {
            new Point(-1, -1, -3.3),
            new Point(-1, 1, 14.7),
            new Point(-1, 3, 7.7),
            new Point(-1, 5, 17.7),
            new Point(-1, 7, 24.7),
            new Point(-1, 9, 35.7),
            new Point(1, -1, -1.3),
            new Point(1, 1, -0.7),
            new Point(1, 3, 10.3),
            new Point(1, 5, 7.3),
            new Point(1, 7, 12.3),
            new Point(1, 9, 30.3),
            new Point(3, -1, -8.1),
            new Point(3, 1, -7.1),
            new Point(3, 3, -9.1),
            new Point(3, 5, 11.9),
            new Point(3, 7, 11.9),
            new Point(3, 9, 20.9),
            new Point(5, -1, -10.5),
            new Point(5, 1, -18.5),
            new Point(5, 3, -12.5),
            new Point(5, 5, -1.5),
            new Point(5, 7, 3.5),
            new Point(5, 9, -3.5),
            new Point(7, -1, -25.9),
            new Point(7, 1, -25.9),
            new Point(7, 3, -24.9),
            new Point(7, 5, -3.9),
            new Point(7, 7, -0.9),
            new Point(7, 9, -4.9),
            new Point(9, -1, -27.3),
            new Point(9, 1, -35.3),
            new Point(9, 3, -24.3),
            new Point(9, 5, -30.3),
            new Point(9, 7, -24.3),
            new Point(9, 9, -5.3)
        };
    }

}