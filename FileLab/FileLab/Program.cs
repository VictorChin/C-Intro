using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileLab
{
    class Program
    {
        static void Main(string[] args)
        {
            const string filename = @"C:\readme.txt";
            
            int i = 1;
            foreach (var item in File.ReadAllLines(filename))
            {
                Console.WriteLine($"{i,3}: {item}");
                i++;
            }
            Console.WriteLine(Path.GetTempFileName());
            Console.WriteLine(Path.GetRandomFileName());
            Console.WriteLine(Path.GetFileName(filename));
            Console.WriteLine(Path.GetExtension(filename));
            Console.WriteLine(Path.GetDirectoryName(filename));
            Console.WriteLine(Path.GetFileNameWithoutExtension(filename));
            Console.WriteLine(Path.GetFullPath(filename));
            File.Copy(filename, $"c:\\{ Path.GetRandomFileName()}");
            
            Console.WriteLine(Directory.GetCurrentDirectory());
            FileInfo fi = new FileInfo(filename);
            fi.CopyTo("C:\\test.txt",true);
            foreach (PropertyDescriptor p in TypeDescriptor.GetProperties(fi))
            {
                Console.WriteLine($"{p.Name} : {p.GetValue(fi)}");
            }

        }
    }
}
