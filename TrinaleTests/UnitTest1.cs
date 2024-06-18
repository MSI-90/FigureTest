using Figure;

namespace TrinaleTests;

public class TriangleCheckerTests
{
    [Fact]
    public void GetSemiPerimetr_7_24_25()
    {
        double oneSide = 7, twoSide = 24, thirtSide = 25;
        double resultSemiPerimetr = (oneSide + twoSide + thirtSide) / 2;

        Triangle triangle = new Triangle(oneSide, twoSide, thirtSide);
        double actual = triangle.GetSemiPerimetr();

        Assert.Equal(resultSemiPerimetr, actual);
    }

    [Fact]
    public void Square_7_24_25()
    {
        double oneSide = 7, twoSide = 24, thirtSide = 25;
        Triangle triangle = new Triangle(oneSide, twoSide, thirtSide);
        
        double actual = triangle.Square();

        double result = 84;

        Assert.Equal(result, actual);
    }
}