using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3
{
    class Program
    {
        static void Main(string[] args)
        {
            GoEat(Meal.Snack);
            DoSomething((new DateTime(2009,8,23)).DayOfWeek);
            
            Point A = new Point(45, 90);
            Point B = new Point(85, 45);
            Point C = A;
            Console.WriteLine(A);
            Console.WriteLine(B);
            A.x = 100;
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
        internal int x;
        internal int y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        
        public override string ToString() {
            return $"x:{x}, y:{y}";
        }
    }
}
