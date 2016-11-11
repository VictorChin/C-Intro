using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurClient
{
    class Program
    {
        static void Main(string[] args)
        {
            OurClient.Default.Container ctx =
                new OurClient.Default.Container(
                    new Uri("http://odatacanyousee.azurewebsites.net/")
                    );
            var q = from p in ctx.Products
                    where p.ListPrice < 300 && p.ListPrice > 100
                    select new { p.Name, p.ListPrice, p.StandardCost };//Query Expression
            var q2 = ctx.Products.Where(p => (p.ListPrice < 300 && p.ListPrice > 100))
                .Select(p => new { p.Name, p.ListPrice, p.StandardCost });//fluent extension method
            foreach (var item in q.ToList().OrderBy(p=>p.Name))
            {
                Console.WriteLine($"{item.Name} {item.ListPrice} {item.StandardCost}");
            }
        }
    }
}
