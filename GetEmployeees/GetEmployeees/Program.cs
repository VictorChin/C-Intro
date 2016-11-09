using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetEmployeees
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in GetEmployees())
            {
                if (item == "Bob") { break; }
                Console.WriteLine(item);
            }
        }
        static Workers GetEmployees()
        {
            return new Workers();
        }
    }
    class Workers : IEnumerable<string>
    {
        List<string> _worker = new List<string>() { "Abe", "Bob", "John" };

        public IEnumerator<string> GetEnumerator()
        {
            foreach (var item in _worker)
            {
                yield return item;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
