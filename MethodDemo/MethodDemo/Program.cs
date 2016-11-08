using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo theFile;
            long result = FileUtil.GetFileSize(
                inKB: true,
                outFile: out theFile,
                fileName: @"C:\readme.txt");
            Console.WriteLine(result);
            if (theFile != null)
            {
                try
                {
                    StreamReader reader = theFile.OpenText();
                    Console.WriteLine(reader.ReadToEnd());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
              
            }
        }
    }
    class FileUtil
    {

        internal static long GetFileSize(string fileName, out FileInfo outFile, bool inKB = false)
        {
            FileInfo aFile = new FileInfo(fileName);
            outFile = aFile;
            long size = inKB ? aFile.Length / 1024 : aFile.Length;
            return size;
        }
        internal static long GetFileSize(FileInfo fileName)
        {
            return fileName.Length;
        }
    }

}
