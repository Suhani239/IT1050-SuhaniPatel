using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dog
{
    public class Dog
    {
        public string Name { get; set; }

        private void bark()
        {
            Console.WriteLine("{0} is Barking....", Name);
        }

        private void doTrick(string trickName)
        {
            Console.WriteLine("{0} is so smart! {0} is doing a(n) {1}", Name, trickName);
        }
    }
}
