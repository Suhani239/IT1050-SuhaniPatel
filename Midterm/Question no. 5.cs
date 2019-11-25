using System;

namespace Q._no_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <=21)
            {
                if ((i % 2) == 0)
                {
                    Console.Write(" ");
                }
                else if ((i % 2) != 0)
                {
                    Console.Write(i);
                }
                i++;
            }
                
        }
    }
}
