namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Farenheit to Celsius");
            Console.WriteLine(TempConverter.FarenheitToCelsius(32));
            
            Console.WriteLine("Celsius to Farenheit");
            Console.WriteLine(TempConverter.CelsiusToFarenheit(100));
        }
    }
}
