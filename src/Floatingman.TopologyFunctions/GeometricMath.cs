using System;
using Topology.Records;
using static System.Math;

namespace Floatingman.TopologyFunctions;

public static class GeometricMath
{
  public static double DegreesToRadians(this double degrees) => degrees * (Math.PI / 180);
  public static double RadiansToDegrees(this double radians) => radians * (180 / Math.PI);

  // where angle in radians
  public static Point PolarToCartesian(this double angle, double radius) => new Point(radius * Math.Cos(angle), radius * Math.Sin(angle));

  // Missed from System.Math
  public static double Sqr(double v) => v * v;
  public static decimal Sqr(decimal v) => v * v;

  // centroids
  private delegate Point CalculateCentroidFunction(int u, int v);
  public static Point CalculateCentroid(int u, int v, double radius)
  {
    var h = Sqrt(Sqr(radius) - Sqr(radius / 2.0));

    CalculateCentroidFunction f = (u == 0 || u % 2 != 1) ? Even : Odd;
    var centroid = f(u, v);
    return centroid;

    Point Even(int u, int v) => new((u * radius * (3.0 / 2.0)) + radius, (2 * v * h) + h);
    Point Odd(int u, int v) => new((u * radius * (3.0 / 2.0)) + radius, (2 * v * h) + 2 * h);

  }
}