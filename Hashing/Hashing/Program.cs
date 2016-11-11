using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Security.Cryptography;
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

            var crypto =
            EnterpriseLibraryContainer.Current.GetInstance<CryptographyManager>();

            string encryptedContentsBase64 =
                crypto.EncryptSymmetric("RijndaelManaged", "ThisIsCreditCard");

            Console.WriteLine(encryptedContentsBase64); //

            string clearText = crypto.DecryptSymmetric("RijndaelManaged", encryptedContentsBase64);
            Console.WriteLine(clearText);
            crypto.CreateHash("Blah", "dsadassdasda");
        }
    }
}
