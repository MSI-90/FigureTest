namespace Figure.FigureExceptions;

public class BadValueRadiusException : Exception
{
    public BadValueRadiusException() : base("Установлено некорректное значение радиуса окружности")
    { }
}
