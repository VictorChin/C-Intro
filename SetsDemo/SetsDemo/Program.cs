using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> cities = new HashSet<string>()
            {"Abedeen", "Berlin","London","Manchester","New York","Paris"};
            HashSet<string> capitals = new HashSet<string>()
            { "Berlin","London","Paris" };
            if (capitals.IsSubsetOf(cities))
            {
                Console.WriteLine("Capital is a subset of cities");
            }
            else
            {
                Console.WriteLine("Capital is NOT a subset of cities");
            }
            Console.WriteLine("Following cities intersect capitols." );
            var copyOfCities = new HashSet<string>(cities);
            copyOfCities.IntersectWith(capitals);
            foreach (var item in copyOfCities)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Following cities Except capitols.");
            foreach (var item in cities.Except(capitals))
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
