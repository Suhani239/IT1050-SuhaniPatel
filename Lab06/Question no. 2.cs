using System;

namespace Q_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] months = { "1st January", "2nd February", "3rd March", "4th April",
                    "5th May", "6th June", "7th July", "8th August", "9th September", "10th October", "11th November", "12th December" };

            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine(months[i]);
            }
        }
    }
}
