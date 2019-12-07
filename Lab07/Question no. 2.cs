using System;

namespace ConsoleApp2
{
    class BookTest
    {
        static void Main(string[] args)
        {
            Book myBook = new Book("Macbeth", "William Shakespeare", 1623);

            myBook.Display();
        }
    }
}
