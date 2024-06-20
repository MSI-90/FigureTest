namespace Figure.FigureExceptions;

public sealed class BadValueRadiusException : Exception
{
    public BadValueRadiusException() : base("Установлено некорректное значение радиуса окружности")
    { 
    }
}
