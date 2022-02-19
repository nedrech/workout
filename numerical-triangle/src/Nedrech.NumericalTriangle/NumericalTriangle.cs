namespace Nedrech.NumericalTriangle;

public class NumericalTriangle
{
    private readonly double[][] _levels;

    public NumericalTriangle(double[][] levels)
    {
        _levels = levels;
        
        EnsureValid();
    }

    /// <summary>
    /// The function checks the correctness of the triangle levels.
    /// </summary>
    /// <exception cref="ArgumentException">It is thrown out if the level is incorrect</exception>
    private void EnsureValid()
    {
        for (int i = 1; i <= _levels.Length; i++)
            if (i != _levels[i].Length)
                throw new ArgumentException("Incorrect order of levels.");
    }
}