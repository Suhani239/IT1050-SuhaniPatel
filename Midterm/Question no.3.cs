using System;

namespace Q_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 2;
            while (i <= 128)
            {
                {

                    if ((i % 2) == 0)
                    {
                        Console.WriteLine(" [{0}]", i);
                    }
                    else if ((i % 2) != 0)
                    {
                        Console.Write("");
                }
               i*=2;
                
            }
        }   }
    }
}
