using Figure;

namespace FigureTest;

internal class Program
{
    static void Main(string[] args)
    {
        var circle = new Circle(5.5);
        Console.WriteLine(circle.GetSquareAsString());

        var triangle = new Triangle(7, 24, 25);
        Console.WriteLine(triangle.GetSquareAsString());
    }
}
