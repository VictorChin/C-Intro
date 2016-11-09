using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Hashing
{
    class Program
    {
        static void Main(string[] args)
        {
            var algo =  HashAlgorithm.Create("SHA512");
            var hash = algo.ComputeHash(File.Open(@"C:\readme2.txt",FileMode.Open));
            File.WriteAllBytes(@"C:\readme2.hash", hash);
            File.WriteAllText(@"C:\readme2.hash.txt", Convert.ToBase64String(hash));
        }
    }
}
