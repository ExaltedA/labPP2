using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Mid_1
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream file = new FileStream(@"test.xml", FileMode.Create, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(string));
          while(true)
            {
                string s = Console.ReadLine();
                if(s == "SET")
                {
                    string login = Console.ReadLine();
                    string password = Console.ReadLine();
                    xs.Serialize(file, "Login = " + login + " Password = " + password);
                }
                else if(s == "GET")
                {
                    string result = xs.Deserialize(file) as string;
                    Console.WriteLine(result);
                }
                else
                {
                    break;
                }
            }
        }
    }
}
