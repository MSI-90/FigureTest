namespace Figure;

public class Triangle : Figure
{
    private double Perimetr { get; init; }
    private double[] Sides { get; init; } = [];
    public Triangle(double firstSide, double secondtSide, double thirdtSide)
    {
        Sides = [ firstSide, secondtSide, thirdtSide ];
        foreach (var side in Sides)
            Perimetr += side;
    }

    public double GetSemiPerimetr() => Perimetr / 2;
    private string Rectangular()
    {
        var side = Sides[0];
        double[] sidesWithoutLongestSide = new double[Sides.Length - 1];

        for (var i = 1; i < Sides.Length; i++)
        {
            if (Sides[i] > side)
            {
                sidesWithoutLongestSide[i - 1] = side;
                side = Sides[i];
            }  
        }

        var longestSideInRect = Math.Pow(side, 2);
        double sumRectsSidesWithoutLongestSide = default;

        for (var i = 0; i < sidesWithoutLongestSide.Length; i++)
        {
            sumRectsSidesWithoutLongestSide += Math.Pow(sidesWithoutLongestSide[i], 2);
        }

        var result = longestSideInRect == sumRectsSidesWithoutLongestSide ? "Треугольник прямоугольный" : "Треугольник не является прямоугольным";
        return result;
    }
    public override double Square()
    {
        var semiPerimetr = GetSemiPerimetr();
        double result = 1d;

        for (var i = 0; i < Sides.Length; i++)
            result *= semiPerimetr - Sides[i];

        return Math.Sqrt(semiPerimetr * result);
    }
    public override string GetSquareAsString()
    {
        var result = Square();
        if (double.IsNaN(result))
            return "ошибка данных";

        return $"Площадь треугольника равна: {Square()}, {Rectangular()}";
    } 
}
