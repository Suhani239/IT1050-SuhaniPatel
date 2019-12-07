using System;
using System.Collections.Generic;
using System.Text;

namespace _7
{
    class Book
    {
        private string Title;
        private string Author;
        private int Year;

        public Book(string Title, String Author, int Year)
        {
            this.Title = Title;
            this.Author = Author;
            this.Year = Year;
        }
        public Book(string Title, string Author)
        {
            this.Title = Title;
            this.Author = Author;
        }
          
        public void Display()
        {
            Console.WriteLine(" The title is {0} and the author is {1} ", Title, Author);
        }
           
            
        





    }
}
