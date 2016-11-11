using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            KmdDb ctx = new KmdDb();
            //GetACustomers(ctx);
            //First 10 customer, ordered by most recent ModifiedDate
            Top10Customer(ctx);
            //AddAndRemoveCustomer(ctx);
            //InsertToCategories(ctx);
            Console.ReadLine();

        }

        private static void InsertToCategories(KmdDb ctx)
        {
            ctx.ProductCategories.Add(new ProductCategory
            {
                Name = "Pepe",
                ModifiedDate = DateTime.Now,
                rowguid = Guid.NewGuid()
            }
            );
            if (ctx.ProductCategories.Where(p => p.Name == "Pepe2").Count() == 0)
            {
                ctx.ProductCategories.Add(new ProductCategory
                {
                    Name = "Pepe2",
                    ModifiedDate = DateTime.Now,
                    rowguid = Guid.NewGuid()
                }
           );
            }
            ctx.SaveChanges();
        }

        private static void AddAndRemoveCustomer(KmdDb ctx)
        {
            var myCustomer = ctx.Customers.Find(544);
            myCustomer.CompanyName = "Firebrand";
            ctx.SaveChanges();

            ctx.Customers.RemoveRange(ctx.Customers.Where(c => c.CompanyName == "Firebrand"));
            ctx.SaveChanges();
            Top10Customer(ctx);
        }

        private static void Top10Customer(KmdDb ctx)
        {
            var q = ctx.Customers.OrderByDescending(c => c.ModifiedDate).Take(10).ToList<Customer>();

            foreach (var item in q)
            {
                Console.WriteLine($"{item.CustomerID} -{item.CompanyName}" );
                foreach (var addr in item.CustomerAddresses)
                {
                    Console.WriteLine($"\t{addr.Address.City}");
                }
            }
        }

        private static void GetACustomers(KmdDb ctx)
        {
            var q = ctx.Customers.Where(c => c.FirstName.StartsWith("A"));

            foreach (var item in q)
            {
                Console.WriteLine(item.FirstName);
            }
        }
    }
}
