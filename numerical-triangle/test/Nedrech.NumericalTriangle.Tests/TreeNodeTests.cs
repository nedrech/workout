using System.Linq;
using Xunit;

namespace Nedrech.NumericalTriangle.Tests;

public class TreeNodeTests
{
    [Fact]
    public void Should_Create_Object()
    {
        // Arrange
        double[][] levels = {
            new[] {1.0},
            new[] {2.0, 3},
            new[] {4.0, 5, 6}
        };
        
        // Act
        TreeNode tn = TreeNode.CreateTree(levels);
        
        // Assert
        Assert.Equal(1, tn.Data);
        Assert.Equal(2, tn.Left?.Data);
        Assert.Equal(3, tn.Right?.Data);
        Assert.Equal(4, tn.Left?.Left?.Data);
        Assert.Equal(5, tn.Left?.Right?.Data);
        Assert.Equal(5, tn.Right?.Left?.Data);
        Assert.Equal(6, tn.Right?.Right?.Data);
    }

    [Fact]
    public void Should_Calc_All_Fin_Sums()
    {
        // Arrange
        double[][] levels1 = {
            new[] {1.0},
            new[] {2.0, 3},
            new[] {4.0, 5, 6}
        };
        double[][] levels2 = {
            new[] {1.0},
            new[] {2.0, 3},
            new[] {4.0, -5, -6}
        };
        TreeNode tn1 = TreeNode.CreateTree(levels1);
        TreeNode tn2 = TreeNode.CreateTree(levels2);
        
        // Act
        var endSums1 = tn1.CalcFinSums().ToArray(); // Length = 4 
        var endSums2 = tn2.CalcFinSums().ToArray(); // Length = 3, because ISet is used

        // Assert
        Assert.Equal(7, endSums1[0]);
        Assert.Equal(8, endSums1[1]);
        Assert.Equal(9, endSums1[2]);
        Assert.Equal(10, endSums1[3]);
        Assert.Equal(7, endSums2[0]);
        Assert.Equal(-2, endSums2[1]);
        Assert.Equal(-1, endSums2[2]);
        Assert.Equal(-2, endSums2[1]); // because ISet is used
    }
}