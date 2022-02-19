using System;
using Xunit;

namespace Nedrech.NumericalTriangle.Tests;

public class NumericalTriangleTests
{
    [Fact]
    public void Should_Throws_On_Incorrect_Argument()
    {
        // Arrange
        double[][] levels = {
            new[] {1.0},
            new[] {1.0, 1},
            new[] {1.0, 1},
            new[] {1.0, 1, 1, 1}
        };
        
        // Act
        // Assert
        Assert.Throws<ArgumentException>(() => new NumericalTriangle(levels));
    }

    [Fact]
    public void Should_Create_Object()
    {
        // Arrange
        double[][] levels = {
            new[] {1.0},
            new[] {1.0, 1},
            new[] {1.0, 1, 1},
            new[] {1.0, 1, 1, 1}
        };
        
        // Act
        NumericalTriangle nt = new(levels);
        
        // Assert
        Assert.NotNull(nt);
    }

    [Fact]
    public void Should_Calculate_Max_Sum()
    {
        // Arrange
        double[][] levels = {
            new[] {1.0},
            new[] {2.0, 3},
            new[] {4.0, 5, 6}
        };
        NumericalTriangle nt = new(levels);

        // Act
        var result = nt.MaxSum;
        
        // Assert
        Assert.Equal(10, result);
    }
}