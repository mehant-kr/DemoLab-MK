using DemoConsoleApp;
using Xunit;

public class CalculatorTests
{
    [Fact]
    public void Add_ReturnsCorrectValue()
    {
        int result = Calculator.Add(2, 3);
        Assert.Equal(5, result);
    }
}
