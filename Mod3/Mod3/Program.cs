using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utitlity;

namespace Mod3
{


    class Program
    {
        static void Main(string[] args)
        {
            //VisibilitySampleAndOverLoadingOp();
            //EnumStruct();
            //GarageTest();
            //DictionaryTest();
            //StackAndQueue();
            //LinqDemo();
            List<Person> people = new List<Person>()
            {
                new Person { Account=100,Name="bob" },
                new Person { Account=200,Name="aron" },
                  new Person { Account=150,Name="Jen" }
            };
            people.Sort();
            foreach (var item in people)
            {
                Console.WriteLine($"{item.Name} has {item.Account}");
            }
        }

        private static void VisibilitySampleAndOverLoadingOp()
        {
            DateTime aTime = new DateTime(64, 7, 21, new TaiwanCalendar());
            var guess = (DateTime.Now - aTime);
            Console.WriteLine(guess.Days / 365.25);
            Person A = new Person() { Account = 200, Name = "Bob" };
            Person B = new Person() { Account = 400, Name = "Jill" };
            int total = A + B;
            Console.WriteLine(A.Spouse.Name);
            Console.WriteLine(B.Spouse.Name);
            Console.WriteLine(total);
        }

        private static void LinqDemo()
        {
            List<int> randInt = new List<int>();
            Random rng = new Random();
            for (int i = 0; i < 100; i++)
            {
                randInt.Add(rng.Next(1000));
            }
            Console.WriteLine(randInt.Max());
            Console.WriteLine(randInt.Min());
            Console.WriteLine(randInt.Average());
            Console.WriteLine(randInt.Distinct().Count());
            Console.WriteLine(randInt.Where(i => i % 7 == 0).Count());

            foreach (var item in randInt.GroupBy(i => i).Where(i => i.Count() > 1))
            {
                Console.WriteLine($" {item.Key} {item.Count()}");
            }
        }

        private static void StackAndQueue()
        {
            var something = new Stack<Garage>();
            for (int i = 0; i < 5; i++)
            {
                var g = new Garage(i);
                g.Park($"Car {i}");
                something.Push(g);
            }
            foreach (var item in something)
            {
                Console.WriteLine(item);
            }
        }

        private static void DictionaryTest()
        {
            var ourGarages = new SortedDictionary<string, Garage>();
            ourGarages.Add("Victor", new Garage(5));
            ourGarages.Add("Soren", new Garage(15));
            ourGarages.Add("Christian", new Garage(3));
            ourGarages["Victor"].Park("Honda");
            ourGarages["Victor"].Park("Nissan");
            ourGarages["Soren"].Park("BMW");
            //ourGarages["Christian"].Park("Aygo");

            foreach (var item in ourGarages)
            {
                if (item.Value.NumberOfCars == 0)
                {
                    Console.WriteLine($"Poor guy {item.Key} got no car!");
                }
                else
                { Console.WriteLine($"{item.Key} - {item.Value}"); }
            }
        }

        private static void GarageTest()
        {
            Garage myGarage = new Garage(5);
            myGarage.CarLeft += 
                (a, b, c) => Debug.WriteLine($"{a} has left on {b}. There {c} spots left");
            myGarage.CarLeft +=
                (a, b, c) => Debug.WriteLine($"{a} has left on {b}. There {c} spots left");

            myGarage.CarParked += 
                (a, b, c) => Debug.WriteLine($"{a} has arrived on {b}. There {c} spots left");
            myGarage.Park("Nissan");
            myGarage.Park("Aygo");
            myGarage.Park("Yugo");
            Console.WriteLine($"there are {myGarage.NumberOfCars} cars");
            myGarage.Fetch("Nissan");
            Console.WriteLine($"there are {myGarage.NumberOfCars} cars");
            Console.WriteLine(myGarage);
            Console.WriteLine("looping through all cars");
            foreach (var item in myGarage)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("end looping through all cars");
        }

        private static void EnumStruct()
        {
            GoEat(Meal.Snack);
            DoSomething((new DateTime(2009, 8, 23)).DayOfWeek);

            Point A = new Point(45, 90);
            A.X = 101;

            Point B = new Point(85, 45);

            Point C = A;
            Console.WriteLine(A);
            Console.WriteLine(B);
            A.X = 100;
            Console.WriteLine(A);
            Console.WriteLine(C);
        }

        static void DoSomething(DayOfWeek today)
        {
            switch (today)
            {
                case DayOfWeek.Sunday:
                case DayOfWeek.Saturday:
                    Console.WriteLine("Weekends");
                    break;
                case DayOfWeek.Monday:
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                case DayOfWeek.Friday:
                    Console.WriteLine("Weekdays");
                    break;
                default:
                    break;
            }
        }
        static void GoEat(Meal what)
        {
            switch (what)
            {
                case Meal.Breakfast:
                    Console.WriteLine("Egg and Ham");
                    break;
                case Meal.Lunch:
                    Console.WriteLine("Meat");
                    break;
                case Meal.Dinner:
                    Console.WriteLine("Red Meat");
                    break;
                case Meal.Snack:
                    Console.WriteLine("Meat Jerky");
                    break;
                default:
                    break;
            }
        }
    }
    enum Meal
    {
        Breakfast,
        Lunch,
        Dinner,
        Snack
    }
    struct Point {
        private int _x;
        public int X {
                get { return _x; }
                set {
                        if (value > 100 || value < 0 )
                         { throw new ArgumentOutOfRangeException(); }
                        _x = value;
                    }
                        }
        private int _y;
        public int Y
        {
            get { return _y; }
            set
            {
                if (value > 100 || value < 0)
                { throw new ArgumentOutOfRangeException(); }
                _y = value;
            }
        }

        private int _z;

        public int Z
        {
            get { return _z; }
            set { _z = value; }
        }



        public Point(int x, int y)
        {
            _x = 0;
            _y = 0;
            _z = 0;
            //this._x = x;
            this.X = x;
            this._y = y;
            //this._y = y;
        }

        public override string ToString()
        {
            return $"x:{_x}, y:{_y}";
        }
    }
}
