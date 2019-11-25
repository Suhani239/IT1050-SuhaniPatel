using System;

namespace Q_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 20;
            Boolean keepLooping = true;
            while (keepLooping)
            {
                if (i <= 19)

                    keepLooping = false;
                i++;
                Console.WriteLine(i);
            }

        }
    }
}
