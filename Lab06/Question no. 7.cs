using System;

namespace Q_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

            int i = 0;
            foreach (string name in names)
            {
                Console.WriteLine("{0,2}. {1}", i, names[i]);
                i++;
            }
        }
    }
}
