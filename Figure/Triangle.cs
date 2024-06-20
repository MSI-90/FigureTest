using Figure.FigureExceptions;
using System.Drawing;

namespace Figure;

public class Triangle : Figure
{
    private double Perimetr { get; init; }
    private double[] Sides { get; init; } = [];
    public Triangle(double firstSide, double secondtSide, double thirdtSide)
    {
        Sides = [ firstSide, secondtSide, thirdtSide ];
        if (IsValidSides(Sides))
            foreach (var side in Sides)
                Perimetr += side;
    }

    public bool IsValidSides(double[] values)
    {
        foreach (var side in values)
        {
            if (side <= 0)
                throw new BadValuesTriangleException("Invalid value of one or more sides for triangle");
        }

        var maxValueSide = values.Max();
        int countOfMaxValue = values.Count(v => v.Equals(maxValueSide));
        double[] tempArray;
        if (countOfMaxValue == values.Length)
        {
            tempArray = [ values[0], values[1] ];
        }
        else
        {
            tempArray = new double[values.Length - 1];
            int tempArrayIndex = 0;

            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] != maxValueSide)
                {
                    tempArray[tempArrayIndex] = values[i];
                    tempArrayIndex++;
                }
            }
        }

        double summ = 0d;
        foreach(var item in tempArray)
            summ += item;         

        return maxValueSide >= summ 
            ? throw new GreaterOrSameValuesTriangleException("One of the sides of a triangle is greater than the sum of the other two sides. " +
                "It is also possible that two or more sides are equal ")
            : true;
    }

    public double GetSemiPerimetr() => Perimetr / 2;
    public string Rectangular()
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

        return Math.Round(Math.Sqrt(semiPerimetr * result), 2);
    }
    public override string GetSquareAsString()
    {
        var result = Square();
        if (double.IsNaN(result))
            return "ошибка данных";

        return $"Площадь треугольника равна: {Square()}";
    } 
}
