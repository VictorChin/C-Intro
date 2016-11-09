using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Casting
{
    public class Cat : Animal
    {
        public void Scratch()
        {
            Console.WriteLine("Scratch");
        }
        public override void Speak()
        {
            Console.WriteLine("Meow");
        }
    }
}