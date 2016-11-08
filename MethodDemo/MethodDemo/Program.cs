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
            FileInfo theFile=null;
            try
            {
                long result = FileUtil.GetFileSize(
                   inKB: true,
                   outFile: out theFile,
                   fileName: @"C:\readme.txt");
                Console.WriteLine(result);
            }
            catch (ArgumentOutOfRangeException ex )
            {
                Console.WriteLine("bad argument:" + ex.ParamName);
                Console.WriteLine("reason:" + ex.Message);
            }


            if (theFile != null)
            {
                try
                {
                    StreamReader reader = File.OpenText(@"c:\readme.txt");
                    Console.WriteLine(reader.ReadToEnd());
                }
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine("Invalid File,look at your files again");
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally {
                    Console.WriteLine("Finally");
                }
              
            }
        }
    }
    class FileUtil
    {

        internal static long GetFileSize(string fileName, out FileInfo outFile, bool inKB = false)
        {
            if (fileName.EndsWith("txt"))
                { throw new ArgumentOutOfRangeException(nameof(fileName),"I don't like txt"); }

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
