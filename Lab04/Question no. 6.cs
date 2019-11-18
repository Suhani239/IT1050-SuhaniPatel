using System;

namespace Question_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the exhibit number: 1-9");

            {
                string str = Console.ReadLine();
                int caseswitch = int.Parse(str);
                switch (caseswitch)
                {
                    case 1:
                        Console.WriteLine("Polar Bear");
                        break;
                    case 2:
                        Console.WriteLine("Penguin");
                        break;
                    case 3:
                        Console.WriteLine("Moose");
                        break;
                    case 4:
                        Console.WriteLine("Reindeer");
                        break;
                    case 5:
                        Console.WriteLine("Deer");
                        break;
                    case 6:
                        Console.WriteLine("Turtle");
                        break;
                    case 7:
                        Console.WriteLine("Lion");
                        break;
                    case 8:
                        Console.WriteLine("Fish");
                        break;
                    case 9:
                        Console.WriteLine("Bug");
                        break;
                }














                }
            }
    }
}
