using Figure;

namespace CircleSquare.Tests;

public class CircleCheckerTests
{
    [Fact]
    public void CreateCircle_5radius()
    {
        Circle circle = new Circle(5);
        double result = 78.54;

        double actual = circle.Square();

        Assert.Equal(result, actual);
    }
}