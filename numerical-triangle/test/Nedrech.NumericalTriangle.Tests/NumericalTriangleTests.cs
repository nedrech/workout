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
}