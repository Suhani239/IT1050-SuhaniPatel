using System;

namespace Q_4
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 101; i++)
            {
                Console.WriteLine(i);
                {
                    if ((i % 2) == 0)
                    {
                        Console.WriteLine("Number is even");
                    }
                    else if ((i % 2) != 0)
                    {
                        Console.WriteLine("Number is odd");
                    }

                }
            }
        }
    }
}
