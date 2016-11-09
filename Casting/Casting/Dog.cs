using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Casting
{
    public sealed class Dog : Animal
    {
        public void Bite() {
            Console.WriteLine("Biting");
        }
        public override void Speak()
        {
            Console.WriteLine("Woof");
        }
    }
}