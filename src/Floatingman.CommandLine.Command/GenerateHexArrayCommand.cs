using System;
using System.Text;
using Floatingman.CommandLineParser.Parser;
using static Floatingman.TopologyFunctions.GeometricMath;

namespace Floatingman.CommandLine.Command;

public class GenerateHexArrayCommand : Command<GenerateHexArrayArgs>, ICommand
{
    public override string Name =>  "GenerateHexArray";

    public override string ShortHelp => "Generates an array of hexes, Rows (U) * Columns (V) and Radius";

    public string Description => ShortHelp;

    public override string Execute(GenerateHexArrayArgs args)
    {
        var sb = new StringBuilder();
        for (var u = 0; u < args.Columns; u++)
        for (var v = 0; v < args.Rows; v++)
        {
            var centroid = CalculateCentroid(u, v, args.Radius);
            sb.Append($"POINT ({centroid.X} {centroid.Y}){Environment.NewLine}");
        }
        return sb.ToString();
    }


}