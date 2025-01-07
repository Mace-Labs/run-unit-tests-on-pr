using ExampleProject.Calculators;

namespace ExampleProject.Tests.Calculators;

public class MathCalculatorTests
{
    private readonly MathCalculator _calculator = new();
    
    [Fact]
    public void Add_WithTwoNumbers_ReturnsCorrectResult()
    {
        // Arrange
        const double x = 5;
        const double y = 3;

        // Act
        var result = _calculator.Add(x, y);

        // Assert
        Assert.Equal(8, result);
    }

    [Fact]
    public void Subtract_WithTwoNumbers_ReturnsCorrectResult()
    {
        // Arrange
        const double x = 10;
        const double y = 4;

        // Act
        var result = _calculator.Subtract(x, y);

        // Assert
        Assert.Equal(6, result);
    }

    [Fact]
    public void Multiply_WithTwoNumbers_ReturnsCorrectResult()
    {
        // Arrange
        const double x = 7;
        const double y = 6;

        // Act
        var result = _calculator.Multiply(x, y);

        // Assert
        Assert.Equal(42, result);
    }

    [Fact]
    public void Divide_WithTwoNumbers_ReturnsCorrectResult()
    {
        // Arrange
        const double x = 15;
        const double y = 3;

        // Act
        var result = _calculator.Divide(x, y);

        // Assert
        Assert.Equal(5, result);
    }
}