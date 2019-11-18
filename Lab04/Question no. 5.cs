using System;

namespace Question_5
{
    class Program
    {
        static void Main(string[] args)
        {
            
           
            Console.WriteLine("Please enter a temperature");
            int temperature = Convert.ToInt32(Console.ReadLine());

            {     
                if (temperature < 10)
                    Console.WriteLine("Polar bear");
                else if (temperature < 20)
                    Console.WriteLine("Penguin");
                else if (temperature < 40)
                    Console.WriteLine("Moose");
                else if (temperature < 50)
                    Console.WriteLine("Reindeer");
                else if (temperature < 60)
                    Console.WriteLine("Deer");
                else if (temperature < 70)
                    Console.WriteLine("Turtle");
                else if (temperature < 80)
                    Console.WriteLine("Lion");
                else if (temperature < 90)
                    Console.WriteLine("Fish");
            }
        }

       

            
        
    }
}
