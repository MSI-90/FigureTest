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
    public void Square_RandomSides()
    {
        Random rand = new Random();
        double oneSide = rand.NextDouble() * 10, twoSide = rand.NextDouble() * 10, thirtSide = rand.NextDouble() * 10;
        Triangle triangle = new Triangle(oneSide, twoSide, thirtSide);
        var semiPerimetr = triangle.GetSemiPerimetr();

        double actual = triangle.Square();


        double result = Math.Sqrt(semiPerimetr * (semiPerimetr - oneSide) * (semiPerimetr - twoSide) * (semiPerimetr - thirtSide));

        Assert.Equal(result, actual);
    }
}