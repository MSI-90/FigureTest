namespace Figure;

public class Circle : Figure
{
    private double Radius { get; init; }
    public Circle(double radius) => Radius = radius;
    public override double Square() => Math.PI * (Math.Pow(Radius, 2));
    public override string GetSquareAsString() => $"Площадь окружности равна: {Square()}";
}
