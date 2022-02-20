namespace Nedrech.NumericalTriangle;

/// <summary>
/// A class for describing a numerical triangle.
/// </summary>
public class NumericalTriangle
{
    private readonly double[][] _levels;

    private readonly Lazy<double> _maxSum;

    public double MaxSum => _maxSum.Value;

    public NumericalTriangle(double[][] levels)
    {
        _levels = levels;
        EnsureValid();
        _maxSum = new Lazy<double>(CalcMaxSum);
    }

    /// <summary>
    /// The function checks the correctness of the triangle levels.
    /// </summary>
    /// <exception cref="ArgumentException">It is thrown out if the level is incorrect</exception>
    private void EnsureValid()
    {
        if (_levels.Where((t, i) => i + 1 != t.Length).Any())
            throw new ArgumentException("Incorrect order of levels.");
    }

    /// <summary>
    /// The function finds the maximum sum of the triangle numbers in depth.
    /// </summary>
    /// <returns>Maximum sum of the triangle numbers.</returns>
    private double CalcMaxSum()
    {
        
        return 0;
    }
}