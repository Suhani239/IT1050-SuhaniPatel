using System;

namespace Q_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string j = ",";
            int i;
            for (i= 49; i >= 1; --i)
            {
                Console.Write(i);
                if (i>=2)
                {
                    Console.Write(j);
                }
            }
        }
    }
}
