namespace Nedrech.NumericalTriangle;

/// <summary>
/// A class for describing a double binary tree.
/// </summary>
/// <remarks>
/// However, two node can refer to the same. It is necessary to solve the problem.
/// </remarks>
public class TreeNode
{
    public double Data { get; private init; }

    public TreeNode? Left { get; private init; }

    public TreeNode? Right { get; private init; }

    /// <summary>
    /// A method for calculating all possible finite sums.
    /// </summary>
    /// <returns>All possible sums.</returns>
    public IEnumerable<double> CalcFinSums() =>
        CalcSums(new HashSet<TreeNode>(), new HashSet<double>(), this);

    /// <summary>
    /// A recursive method for calculating all possible finite sums.
    /// </summary>
    private HashSet<double> CalcSums(HashSet<TreeNode> nodes, HashSet<double> finSums, TreeNode node, double sum = 0)
    {
        nodes.Add(node);
        if (node.Left != null && !nodes.Contains(node.Left))
            finSums = CalcSums(nodes, finSums, node.Left, node.Data + sum);
        if (node.Right != null && !nodes.Contains(node.Right))
            finSums = CalcSums(nodes, finSums, node.Right, node.Data + sum);
        if (node.Right == null && node.Left == null)
            finSums.Add(node.Data + sum);
        return finSums;
    }

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
        i >= arr.Length
            ? parent
            : new TreeNode
            {
                Data = arr[i][j],
                Left = InsertLevel(arr, parent?.Left, i + 1, j),
                Right = InsertLevel(arr, parent?.Right, i + 1, j + 1)
            };
}