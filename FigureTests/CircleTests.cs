using Figure.FigureExceptions;

namespace Figure.Tests;

[TestClass()]
public class CircleTests
{
    private Circle circle;

    public void Circle_CreateTest(double radius)
    {
        circle = new Circle(radius);
        Console.WriteLine("The circle object has been created");
    }

    [ExpectedException(typeof(BadValueRadiusException), "Exception was not throw")]
    [DataTestMethod]
    [DataRow(-5)]
    [DataRow(0)]
    public void Circle_BadValueRadiusTest(double testRadius)
    {
        Circle_CreateTest(testRadius);
    }

    [DataTestMethod]
    [DataRow(5, 78.54)]
    [DataRow(5.5, 95.03)]
    [DataRow(11.11, 387.77)]
    public void Square_ValidTest(double testData, double expectedResult)
    {
        Circle_CreateTest(testData);
        double actual = circle.Square();

        Assert.AreEqual(expectedResult, actual, $"The square of circle with radius - {testData} must be eaual {expectedResult}");

    }

    [DataTestMethod]
    [DataRow(5, 78.5)]
    [DataRow(5.5, 95.05)]
    [DataRow(11.11, 387.76)]
    public void Square_InValidTest(double testData, double expectedResult)
    {
        Circle_CreateTest(testData);
        double actual = circle.Square();

        Assert.AreNotEqual(expectedResult, actual, $"The square of circle with radius - {testData} must be eaual {expectedResult}");

    }

    [DataTestMethod]
    [DataRow(5, 78.54)]
    [DataRow(5.5, 95.03)]
    [DataRow(11.11, 387.77)]
    public void GetSquareAsString_ValidTest(double testData, double expectedResult)
    {
        Circle_CreateTest(testData);

        string validText = $"Площадь окружности равна: {expectedResult}";
        string actual = circle.GetSquareAsString();

        Assert.AreEqual(validText, actual, $"The GetSquareAsString method should return {validText}, but it returned {actual}");
    }

    [DataTestMethod]
    [DataRow(5, 78.5)]
    [DataRow(5.5, 95.05)]
    [DataRow(11.11, 387.76)]
    public void GetSquareAsString_InValidTest(double testData, double expectedResult)
    {
        Circle_CreateTest(testData);

        string validText = $"Площадь окружности равна: {expectedResult}";
        string actual = circle.GetSquareAsString();

        Assert.AreNotEqual(validText, actual, $"The GetSquareAsString method should return {validText}, but it returned {actual}");
    }
}