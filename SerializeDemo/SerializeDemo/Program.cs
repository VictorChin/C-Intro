using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerializeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee victor = new Employee { Name = "Victor" ,Age=42};
            //XmlSerializer genie = new XmlSerializer(victor.GetType());
            //var dest = File.Open(@"MySoap.xml", FileMode.OpenOrCreate);
            //dest.Position = 0;
            //Employee v = genie.Deserialize(dest) as Employee;

            JsonSerializer genie = new JsonSerializer();
            StreamWriter s = new StreamWriter(File.Open(@"MyJson.json",FileMode.OpenOrCreate));
            genie.Serialize(
                s,//where to
                victor//the object to serialize
                );
            //s.Flush();
            s.Close();
            //Process.Start("Notepad.exe", "MyJson.json");
            StreamReader r = new StreamReader(File.Open(@"MyJson.json", FileMode.OpenOrCreate));
            Employee v = genie.Deserialize<Employee>(new JsonTextReader(r));
            Console.WriteLine(v);
        }
    }
   [Serializable]
   [XmlRoot("Worker", Namespace ="/MyCompany/HR")]
   public class Employee {
        [XmlAttribute]
        public string Name { get; set; }
        [XmlElement]
        public int Age { get; set; }
   
    }
}
