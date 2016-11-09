using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random rng = new Random();
            Animal anAnimal;

            if (rng.Next(10) > 5)
            {
                anAnimal = new Cat();
                
            }
            else
            {
                anAnimal = new Dog();
            }
            anAnimal.Speak();


            if (anAnimal is Dog)
            {
                Dog x = anAnimal as Dog;
                x.Bite();
            }
            if (anAnimal is Cat)
            {
                Cat x = anAnimal as Cat;
                x.Scratch();
            }

            try
            {
                Cat aCat = (Cat)anAnimal;
                aCat.Scratch();
            }
            catch (Exception)
            {
                (anAnimal as Dog).Bite();
                throw;
            }

            Dog another = anAnimal as Dog;
            if (another != null)
            {
                another.Bite();
            }
            Cat anotherCat = anAnimal as Cat;
            if (anotherCat != null)
            {
                anotherCat.Scratch();
            }

           

            

            Console.ReadLine();

        }
    }
    
}
