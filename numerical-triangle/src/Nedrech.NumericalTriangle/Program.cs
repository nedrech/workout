using Nedrech.NumericalTriangle;

LevelsCountInput:
Console.Write("Enter the height of the triangle (number of levels): ");
uint n;
try
{
    n = uint.Parse(Console.ReadLine() ?? string.Empty);
}
catch (FormatException e)
{
    Console.WriteLine(e.Message);
    goto LevelsCountInput;
}
catch (OverflowException e)
{
    Console.WriteLine(e.Message);
    goto LevelsCountInput;
}

Console.WriteLine("Enter the level numbers each on a new line, separated by a space.");
LevelsInput:
Console.WriteLine("Example (comma for fractional numbers):");
Console.WriteLine("1,25");
Console.WriteLine("1 2");
Console.WriteLine("1 2,2 3");
double[][] levels = new double[n][];
try
{
    for (int i = 0; i < n; i++)
    {
        Console.Write($"[{i + 1}/{n}]: ");
        levels[i] = (Console.ReadLine() ?? string.Empty).Split().Select(double.Parse).ToArray();
    }
}
catch (FormatException e)
{
    Console.WriteLine(e.Message);
    goto LevelsInput;
}

NumericalTriangle nTriangle;
try
{
    nTriangle = new NumericalTriangle(levels);
}
catch (ArgumentException e)
{
    Console.WriteLine(e.Message);
    Console.WriteLine("Repeat entering the triangle.");
    goto LevelsInput;
}

Console.WriteLine($"Max sum: {nTriangle.MaxSum}.");
Console.Write("Would you like to introduce another example? (y/[n]) ");
if ((Console.ReadLine() ?? string.Empty).Normalize().StartsWith("y"))
    goto LevelsCountInput;