using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //NewMethod();
            //NewMethod1();
            string input,first,second;
            float a, b, result;
            do
            {
                bool doAgain = false;
                Console.WriteLine("Enter 1 for String Add, 2 for Number Add");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        StringAdder(out first, out second);
                        break;
                    case "2":
                        NumberAdder(out a, out b);
                        break;
                    default:
                        doAgain = true;
                        break;
                }
                if (doAgain) {

                    Console.WriteLine("I don't do " + input);
                    Console.WriteLine("Try Again Y or N?");
                    continue; }

            } while ((input = Console.ReadLine())=="Y");
            Console.WriteLine("Program finised, press enter to end program.");
            Console.ReadLine();
        }

        private static void NumberAdder(out float first, out float second)
        {
            Console.WriteLine("First number");
            first = float.Parse(Console.ReadLine());
            Console.WriteLine("Second number");
            second = float.Parse(Console.ReadLine());
            Console.WriteLine(first + second);
            Console.WriteLine("Again?[Y/N]");

        }

        private static void StringAdder(out string first, out string second)
        {
            Console.WriteLine("First String?");
            first = Console.ReadLine();
            Console.WriteLine("Second String?");
            second = Console.ReadLine();
            Console.WriteLine($"{first} {second}");
            Console.WriteLine("Again?[Y/N]");
        }

        private static void NewMethod1()
        {
            int x = 5;
            int y = 2, z = 10;
            Console.WriteLine((float)x / y);
            byte a = byte.MaxValue;
            short b = short.MaxValue;
            int c = int.MaxValue;
            long d = long.MaxValue;
            char e = 'x';
            string f = "blah";
            string input;
            Console.WriteLine("Enter Something:");
            while ((input = Console.ReadLine()) != string.Empty)
            {
                Console.WriteLine("You entered: {0}", input);
                Console.WriteLine("Enter Something:");
            }

            Console.WriteLine("a:{0}\nb:{1}\nc:{2}\nd:{3}", ++a, b, c, ++d);
            if (DateTime.UtcNow.DayOfWeek == DayOfWeek.Monday)
            {
                if (DateTime.UtcNow.Hour < 12.5 && d > 100)
                { Console.WriteLine("MORNING"); }
                Console.WriteLine(e);
            }
            else
            { Console.WriteLine(f); }
                    ;
        }

        private static void NewMethod()
        {
            string firstname = "Samir";
            string lastname = "Skrijeji";
            string fullname = firstname + " " + lastname;
            Console.WriteLine(fullname);
            Console.WriteLine("Hello World");
            Console.WriteLine("The variable is called" + nameof(fullname));
            string input = Console.ReadLine();
            Console.WriteLine("you entered " + input.PadRight(20, '*') + ".");
            Console.ReadLine();
        }
    }
}
