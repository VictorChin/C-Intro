using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //StringTestAndRegSample();
            HttpClient browser = new HttpClient();

            var result = browser.GetStringAsync(@"http://www.google.com");
            result.Wait(30000);
            Console.WriteLine(result.Result); 
            var matches = Regex.Matches(result.Result, 
                @"(http|https|ftp)\://[a-zA-Z0-9\-\.]+\.[a-zA-Z]{2,3}(:[a-zA-Z0-9]*)?/?([a-zA-Z0-9\-\._\?\,\'/\\\+&amp;%\$#\=~])*");
            //for (int i = 0; i < matches.Count; i++)
            //{
            //    Console.WriteLine($"{matches[i].Value}");
            //}
            foreach (Match item in matches)
            {
                Console.WriteLine(item.Value);
            }
            Console.ReadLine();



        }

        private static void StringTestAndRegSample()
        {
            Console.WriteLine("Enter a Postal Code:");
            string input = Console.ReadLine();

            bool isMatch = Regex.IsMatch(input, @"^[D-d][K-k]( |-)[1-9]{1}[0-9]{3}$");

            if (isMatch)
            { Console.WriteLine("Danish Postal Code"); }
            else
            { Console.WriteLine("Not Danish Postal Code"); }



            Stopwatch watch = new Stopwatch();
            watch.Start();
            string x = string.Empty;
            for (int i = 0; i < 5; i++)
            {
                x += i.ToString();
            }
            watch.Stop();
            Console.WriteLine($"using string {watch.ElapsedTicks}");
            //Console.WriteLine("using string" + watch.ElapsedTicks);
            //--------------------------------------------------------//

            watch.Reset();
            watch.Start();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 5; i++)
            {
                sb.Append(i.ToString());
            }
            watch.Stop();
            Console.WriteLine($"using StringBuilder {watch.ElapsedTicks}");
        }
    }
}
