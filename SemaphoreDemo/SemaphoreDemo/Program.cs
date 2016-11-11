using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SemaphoreDemo
{

    class Program
    {
       
        static SemaphoreSlim garage = new SemaphoreSlim(2);
        static void Main(string[] args)
        {
            //Semaphore();
            //PLINQ();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            var t = DemoMethodAsync("http://www.yahoo.com");
            var t2 = DemoMethodAsync("http://www.cnn.com");
            var t3 = DemoMethodAsync("http://www.reddit.com");
            t.Wait();
            t2.Wait();
            t3.Wait();
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
            sw.Reset();
            sw.Start();
            var t4 = DemoMethodAsync("http://www.yahoo.com")
                .ContinueWith((r) => DemoMethodAsync("http://www.cnn.com"))
                .ContinueWith((r) => DemoMethodAsync("http://www.reddit.com"));
            t4.Wait();
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
            Type thing = sw.GetType();
        

            Console.ReadLine();
            
        }

        public static async Task<string> DemoMethodAsync(string url) {
            HttpClient client = new HttpClient();
            string s = await client.GetStringAsync(url);
            return s;
        }
        private static void PLINQ()
        {
            IEnumerable<int> numbers = Enumerable.Range(3, 100000000 - 3);

            var parallelQuery =
              from n in numbers.AsParallel()
              where Enumerable.Range(2, (int)Math.Sqrt(n)).All(i => n % i > 0)
              select n;

            int[] primes = parallelQuery.ToArray();
            Console.WriteLine(primes.Count());
        }

        private static void Semaphore()
        {
            Thread t = new Thread(Park);
            Thread t1 = new Thread(Park);
            Thread t2 = new Thread(Park);
            Thread t3 = new Thread(Park);
            Thread t4 = new Thread(Park);
            Console.WriteLine(garage.CurrentCount);
            t.Start();
            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();
            Console.WriteLine("done");
        }

        static void Park() {
            garage.Wait();
            Console.WriteLine("Parked");
            Thread.Sleep(5000);
            Console.WriteLine("Leaving");
            garage.Release();
        }
    }

  
}
