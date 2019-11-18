using System;

namespace Question_9
{
    class Program
    {
        static void Main(string[] args)

        {   //1st Triangle (A)
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            //2nd Triangle (B)
            for (int i = 10; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();


            //3rd Triangle (C)
            for (int i = 10; i >= 1; i--)
            {
                for (int j = 1; j <= 10 - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            //4th Triangle (D)
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10 - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}
