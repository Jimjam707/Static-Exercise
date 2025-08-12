namespace StaticExercise;

public static class TempConverter
{
    public static double FarenheitToCelsius(double farenheit)
    {
        return (farenheit - 32) * 5 / 9;
    }
    
    public static double CelsiusToFarenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }
}