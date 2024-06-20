namespace Figure.FigureExceptions;

public sealed class BadValuesTriangleException : TriangleException
{
    public BadValuesTriangleException(string message) : base(message)
    {
    }
}
