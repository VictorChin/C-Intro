using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            

            var classRoom = new Container<Person>(12);
            var zoo = new Container<Animal>(50);
            var garage = new Container<Car>(8);

            zoo.ThingEntered += (a, b, c) => {
                if (a.Name == "Tasty Bird") { zoo.Leave(a); }
                                              };
            classRoom.Enter(new Person { Name = "Bob" });
            classRoom.Enter(new Person { Name = "Jim" });
            classRoom.Enter(new Person { Name = "Tom" });
            zoo.Enter(new Animal { Name = "Bird" });
            zoo.Enter(new Animal { Name = "Tasty Bird" });
            zoo.Enter(new Animal { Name = "Small Bird" });
            garage.Enter(new Car { Name = "Nissan" });
            garage.Enter(new Car { Name = "Honda" });

            var dog = new Animal{ Name = "dog" };
            Console.WriteLine(dog.Mamamia(5));
        }
    }

    public abstract class Thing {
        public string Name { get; set; }
        public override string ToString() => $"I am {Name}";
        protected abstract void Jump(int howHigh);
    }
    public class Person : Thing
    {
        protected override void Jump(int howHigh)
        {
            Console.WriteLine("Im jumping");
        }
        internal List<Car> Cars
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
    }
    public class Animal : Thing
    {
        protected override void Jump(int howHigh)
        {
            Console.WriteLine("Animal jumping");
        }
    }
    public class Car : Thing
    {
        protected override void Jump(int howHigh)
        {
            Console.WriteLine("Car jumping");
        }
        internal Person Person
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
    }
    public static class ReverseName {
        public static string Mamamia(this Thing t,int x)
        {
            char[] cArray = t.Name.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;
        }
    }
}
