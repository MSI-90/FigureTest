using Figure.FigureExceptions;

namespace Figure;

public class Circle : Figure
{
    private double Radius { get; init; }
    public Circle(double radius)
    {
        if (radius <= 0)
            throw new BadValueRadiusException();
        Radius = radius;
    }
    public override double Square() => Math.Round(Math.PI * (Math.Pow(Radius, 2)), 2);
    public override string GetSquareAsString() => $"Площадь окружности равна: {Square()}";
}
