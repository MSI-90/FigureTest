using Figure;
using Xunit.Sdk;

namespace TriangleTests;

[TestClass]
public class TriangleCheckerTests : PageTest
{
    [TestMethod]
    public void GetSemiPerimetr_7_24_25()
    {
        double oneSide = 7, twoSide = 24, thirtSide = 25;
        double resultSemiPerimetr = (oneSide + twoSide + thirtSide) / 2;

        Triangle triangle = new Triangle(oneSide, twoSide, thirtSide);
        double actual = triangle.GetSemiPerimetr();

        Assert.AreEqual(resultSemiPerimetr, actual);
    }

    [TestMethod]
    public void CreateTriangle_Square_7_24_25()
    {
        
    }

}
