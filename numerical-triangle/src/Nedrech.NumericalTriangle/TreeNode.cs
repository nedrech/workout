namespace Nedrech.NumericalTriangle;

/// <summary>
/// A class for describing a double binary tree.
/// </summary>
public class TreeNode
{
    public double Data { get; private init; }

    public TreeNode? Left { get; private init; }

    public TreeNode? Right { get; private init; }

    /// <summary>
    /// A method for creating a binary tree.
    /// </summary>
    /// <param name="levels">Binary tree in the form of a 2d array.</param>
    /// <returns>Binary tree.</returns>
    public static TreeNode CreateTree(double[][] levels) =>
        InsertLevel(levels)!;

    /// <summary>
    /// Recursive method for creating a binary tree.
    /// </summary>
    private static TreeNode? InsertLevel(double[][] arr, TreeNode? parent = null, int i = 0, int j = 0) =>
        i >= arr.Length ? parent : new TreeNode
        {
            Data = arr[i][j],
            Left = InsertLevel(arr, parent?.Left, i + 1, j),
            Right = InsertLevel(arr, parent?.Right, i + 1, j + 1)
        };
}