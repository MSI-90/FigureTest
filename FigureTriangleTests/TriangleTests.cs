using Figure.FigureExceptions;

namespace Figure.Tests;

[TestClass()]
public class TriangleTests
{
    private Triangle triangle;
    public void Triangle_CreateTest(double firstSide, double secondtSide, double thirdtSide)
    {
        triangle = new Triangle(firstSide, secondtSide, thirdtSide);
        Console.WriteLine("The object of triangle type has been created");
    }

    [DataTestMethod]
    [DataRow(7, 10, 3.3)]
    [DataRow(7, 5, 6)]
    [DataRow(3, 2, 4)]
    [DataRow(4, 2, 5)]
    [DataRow(9, 12, 4)]
    public void ValuesOfSidesIsValidTest(double firstSide, double secondSide, double thirdtSide)
    {
        Triangle_CreateTest(firstSide, secondSide, thirdtSide);
        double[] arrayValues = { firstSide, secondSide, thirdtSide };
        var actual = triangle.IsValidSides(arrayValues);
        Assert.IsTrue(actual);
    }

    [ExpectedException(typeof(GreaterOrSameValuesTriangleException), "Exception was not throw")]
    [DataTestMethod]
    [DataRow(7, 10, 10)]
    [DataRow(7, 5, 7)]
    [DataRow(3, 2, 8)]
    [DataRow(4, 2, 4)]
    [DataRow(9, 12, 23)]
    public void ValuesOfSidesInValidTest(double firstSide, double secondSide, double thirdtSide)
    {
        Triangle_CreateTest(firstSide, secondSide, thirdtSide);
        double[] arrayValues = { firstSide, secondSide, thirdtSide };
        var actual = triangle.IsValidSides(arrayValues);
    }

    [ExpectedException(typeof(BadValuesTriangleException), "Exception was not throw")]
    [DataTestMethod]
    [DataRow(-7, 10, 3.3)]
    [DataRow(0, 0, 1)]
    [DataRow(3, 2, -71)]
    [DataRow(0, 2, 0)]
    [DataRow(-1, -1, -2)]
    public void Triangle_BadValuesTriangleTest(double firstSide, double secondSide, double thirdtSide)
    {
        Triangle_CreateTest(firstSide, secondSide, thirdtSide);
    }

    [DataTestMethod]
    [DataRow(5, 7, 3.3, 7.65)]
    [DataRow(1.4, 11.0, 10, 11.2)]
    [DataRow(3, 4, 2, 4.5)]
    [DataRow(10, 10, 10, 15)]
    [DataRow(555, 165.56, 720, 720.28)]
    public void GetSemiPerimetrValidTest(double firstSide, double secondSide, double thirdtSide, double result)
    {
        Triangle_CreateTest(firstSide, secondSide, thirdtSide);
        var actual = triangle.GetSemiPerimetr();
        Assert.AreEqual(result, actual);
    }

    [DataTestMethod]
    [DataRow(5, 7, 3.3, 7.66)]
    [DataRow(1.4, 11.0, 10, 11.1)]
    [DataRow(3, 4, 2, 4.2)]
    [DataRow(10, 10, 10, 15.1)]
    [DataRow(555, 165.56, 720, 720.30)]
    public void GetSemiPerimetrInvalidTest(double firstSide, double secondSide, double thirdtSide, double result)
    {
        Triangle_CreateTest(firstSide, secondSide, thirdtSide);
        var actual = triangle.GetSemiPerimetr();
        Assert.AreNotEqual(result, actual);
    }

    [DataTestMethod]
    [DataRow(7, 24, 25)]
    [DataRow(3, 4, 5)]
    [DataRow(5, 12, 13)]
    public void RectangularValidTest(double firstSide, double secondSide, double thirdtSide)
    {
        Triangle_CreateTest(firstSide, secondSide, thirdtSide);
        var actual = triangle.Rectangular();
        string validResult = "Треугольник прямоугольный";
        Assert.AreEqual(actual, validResult, $"The triangle of sides as: {firstSide} {secondSide} {thirdtSide} must be eaual: {validResult}");
    }

    [DataTestMethod]
    [DataRow(7, 24, 21)]
    [DataRow(3, 4, 6)]
    [DataRow(125, 12, 133)]
    public void RectangularInvalidTest(double firstSide, double secondSide, double thirdtSide)
    {
        Triangle_CreateTest(firstSide, secondSide, thirdtSide);
        var actual = triangle.Rectangular();
        string validResult = "Треугольник не является прямоугольным";
        Assert.AreEqual(actual, validResult, $"The triangle of sides as: {firstSide} {secondSide} {thirdtSide} must be eaual: {validResult}");
    }

    [DataTestMethod]
    [DataRow(5, 7, 3.3, 7.57)]
    [DataRow(1.4, 11.0, 10, 5.13)]
    [DataRow(3, 4, 2, 2.9)]
    [DataRow(10, 10, 10, 43.3)]
    [DataRow(555, 165.56, 720, 4300.08)]
    public void SquareTest(double firstSide, double secondSide, double thirdtSide, double result)
    {
        Triangle_CreateTest(firstSide, secondSide, thirdtSide);
        var actual = triangle.Square();
        Assert.AreEqual(actual, result);
    }

    [DataTestMethod]
    [DataRow(5, 7, 3.3, 7.57)]
    [DataRow(1.4, 11.0, 10, 5.13)]
    [DataRow(3, 4, 2, 2.9)]
    [DataRow(10, 10, 10, 43.3)]
    [DataRow(555, 165.56, 720, 4300.08)]
    public void GetSquareAsStringTest(double firstSide, double secondSide, double thirdtSide, double result)
    {
        Triangle_CreateTest(firstSide, secondSide, thirdtSide);
        var validResult = $"Площадь треугольника равна: {result}";
        var actual = triangle.GetSquareAsString();
        Assert.AreEqual(validResult, actual);
    }

    [DataTestMethod]
    [DataRow(5, 7, 3.3, 7.58)]
    [DataRow(1.4, 11.0, 10, 5.14)]
    [DataRow(3, 4, 2, 2.8)]
    [DataRow(10, 10, 10, 43.1)]
    [DataRow(555, 165.56, 720, 4300.10)]
    public void GetSquareAsStringInvalidTest(double firstSide, double secondSide, double thirdtSide, double result)
    {
        Triangle_CreateTest(firstSide, secondSide, thirdtSide);
        var validResult = $"Площадь треугольника равна: {result}";
        var actual = triangle.GetSquareAsString();
        Assert.AreNotEqual(validResult, actual);
    }
}