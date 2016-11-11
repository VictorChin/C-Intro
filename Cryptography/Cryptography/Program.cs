using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.EnterpriseLibrary.Security.Cryptography;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;

namespace Cryptography
{
    class Program
    {
        static void Main(string[] args)
        {
            var crypto = 
                EnterpriseLibraryContainer.Current.GetInstance<CryptographyManager>();
            string encryptedContentsBase64 = 
                crypto.EncryptSymmetric("RijndaelManaged", "ABD!@#$%");
            Console.WriteLine(encryptedContentsBase64);
        }
    }
}
