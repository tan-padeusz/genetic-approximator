namespace GeneticApproximator;

/// <summary>
/// Class representing input point.
/// </summary>
public class InputPoint
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
    /// Creates new input point with random coordinates values.
    /// </summary>
    /// <param name="maxCoordinateValue">Max coordinate value.</param>
    private InputPoint(double maxCoordinateValue)
    {
        double[] coordinates = new double[3];
        for (int i = 0; i < coordinates.Length; i++)
            coordinates[i] = Math.Round(InputPoint.Random.NextDouble() * maxCoordinateValue, 3);
        this.Coordinates = coordinates;
    }

    /// <summary>
    /// Creates new input point with specified coordinates values.
    /// </summary>
    /// <param name="x">X coordinate value.</param>
    /// <param name="y">Y coordinate value.</param>
    /// <param name="z">Z coordinate value.</param>
    private InputPoint(double x, double y, double z)
    {
        double[] coordinates = new double[] { x, y, z };
        this.Coordinates = coordinates;
    }

    public override string ToString()
    {
        return $"[{this.Coordinates[0]} ; {this.Coordinates[1]} ; {this.Coordinates[2]}]";
    }

    /// <summary>
    /// Generates array of input points with random coordinates.
    /// </summary>
    /// <param name="size">Array size.</param>
    /// <param name="maxCoordinateValue">Max coordinate value.</param>
    /// <returns>Array of input points.</returns>
    public static InputPoint[] GenerateInputPoints(int size, double maxCoordinateValue)
    {
        InputPoint[] points = new InputPoint[size];
        for (int i = 0; i < size; i++) points[i] = new InputPoint(maxCoordinateValue);
        return points;
    }

    /// <summary>
    /// Test method that returns fixed array of input points.
    /// </summary>
    /// <returns>Array of test input points.</returns>
    public static InputPoint[] GetTestPoints()
    {
        return new InputPoint[]
        {
            new InputPoint(-1, -1, -3.3),
            new InputPoint(-1, 1, 14.7),
            new InputPoint(-1, 3, 7.7),
            new InputPoint(-1, 5, 17.7),
            new InputPoint(-1, 7, 24.7),
            new InputPoint(-1, 9, 35.7),
            new InputPoint(1, -1, -1.3),
            new InputPoint(1, 1, -0.7),
            new InputPoint(1, 3, 10.3),
            new InputPoint(1, 5, 7.3),
            new InputPoint(1, 7, 12.3),
            new InputPoint(1, 9, 30.3),
            new InputPoint(3, -1, -8.1),
            new InputPoint(3, 1, -7.1),
            new InputPoint(3, 3, -9.1),
            new InputPoint(3, 5, 11.9),
            new InputPoint(3, 7, 11.9),
            new InputPoint(3, 9, 20.9),
            new InputPoint(5, -1, -10.5),
            new InputPoint(5, 1, -18.5),
            new InputPoint(5, 3, -12.5),
            new InputPoint(5, 5, -1.5),
            new InputPoint(5, 7, 3.5),
            new InputPoint(5, 9, -3.5),
            new InputPoint(7, -1, -25.9),
            new InputPoint(7, 1, -25.9),
            new InputPoint(7, 3, -24.9),
            new InputPoint(7, 5, -3.9),
            new InputPoint(7, 7, -0.9),
            new InputPoint(7, 9, -4.9),
            new InputPoint(9, -1, -27.3),
            new InputPoint(9, 1, -35.3),
            new InputPoint(9, 3, -24.3),
            new InputPoint(9, 5, -30.3),
            new InputPoint(9, 7, -24.3),
            new InputPoint(9, 9, -5.3)
        };
    }

}