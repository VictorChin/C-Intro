using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person a = new Person() { CPR= 234 };
            Person b = new Person() { CPR = 123 };
            Console.WriteLine(a==b);
            Console.WriteLine(a.Equals(b));
            Dictionary<Person,string> people = new Dictionary<Person, string>();
            people.Add(a, "object A");
            people.Add(b, "object B");

            
            Console.WriteLine(people[b]);
        }
    }
    class Person
    {
        public int? CPR { get; set; }
        public override int GetHashCode()
        {   //if (CPR == null)
            //    { return 0; }
            //else
            //    { return CPR.Value; }

            if (CPR.HasValue)
            { return CPR.Value; }
            else
            { return 0; }
        }
        public override bool Equals(object obj)
        {
            return (this.CPR == ((Person)obj).CPR);
        }
        public static bool operator ==(Person lhs, Person rhs)
        {
            return lhs.Equals(rhs);
        }
        public static bool operator !=(Person lhs, Person rhs)
        {
            return !lhs.Equals(rhs);
        }
        
    }
}
