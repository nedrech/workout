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
}