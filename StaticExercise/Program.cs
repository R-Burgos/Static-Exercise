namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit = 32;
            double celsius = 0;

            Console.WriteLine($"{celsius}C to Fahrenheit is:");
            Console.WriteLine(TempConverter.CelsiusToFahrenheit(celsius));
            Console.WriteLine("");
            Console.WriteLine($"{fahrenheit}F to Celsius is:");
            Console.WriteLine(TempConverter.FahrenheitToCelsius(fahrenheit));

        }
    }
}
