using System;

namespace Question_no._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input temperature in Fahrenheit");
            Double Fahrenheit = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Double Celsius = (Fahrenheit - 32d) * 5d / 9d;
            Console.WriteLine("Temperature in Celsius is {0}", Celsius);
            Console.ReadLine();

            if (Fahrenheit >= 90)
                Console.WriteLine("It is hot");

            if (Fahrenheit >= 40)
                Console.WriteLine("It is cold");
        }
    }
}
