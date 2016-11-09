using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utitlity
{
    public class Person : IComparable<Person>
    {
        public int A { get; set; }
        private int B { get; set; }
        internal int C { get; set; }
        protected int D { get; set; }
        protected internal int E { get; set; }
        public Person Spouse { get; set; }
        public int Account { get; set; }
        public string Name { get; set; }
     
        public int CompareTo(Person other)
        {
            //return this.Account - other.Account;
            return this.Name.CompareTo(other.Name);
        }

        public static int operator +(Person leftHandSide, Person rightHandSide)
        {
            leftHandSide.Spouse = rightHandSide;
            rightHandSide.Spouse = leftHandSide;

            return leftHandSide.Account + rightHandSide.Account;
        }
    }
    public class House
    {
     
        
        void Test()
        {
           

            Person p = new Person();
            p.A = 10;
            p.C = 10;
            p.E = 15;
        }
    }
    public class Employee : Person
    {
        void Test() {
            this.A = 10;
            //this.B = 10;
            this.C = 10;
            this.D = 10;
            base.D = 10;
            this.E = 10;
            
        }
    }
}
