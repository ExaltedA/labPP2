using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Test789
{
    public class Xmle
    {
        public Xmle() { }
        public Xmle(string path, int saf)
        {

            save(path, saf);
        }
        public void save(string profile, int saf)
        {

            using (FileStream ser = new FileStream(profile, FileMode.Create, FileAccess.Write))
            {
                XmlSerializer formatter = new XmlSerializer(typeof(int));
                formatter.Serialize(ser, saf);

            }
        }
    }
}

   
    public class Serialize

    {


        public Serialize()
        {

        }
        public Serialize(string path, int saf)
        {

            save(path, saf);
        }
        public void save(string profile, int saf)
        {

            using (FileStream ser = new FileStream(profile, FileMode.Create, FileAccess.Write))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(ser, saf);

            }
        }
    }
    class DeSer
    {
        public int b;
        public DeSer() { }
        public DeSer(string path)
        {
            ret(path);
            Console.WriteLine(b);
        }
        void ret(string path)
        {
            using (FileStream ser = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                int f = Convert.ToInt32(formatter.Deserialize(ser));
                b = f;
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                string pathq = @"C:\Users\Exalted\Desktop\Savefile.txt";
                ConsoleKeyInfo tro = Console.ReadKey();
                
                if (tro.Key == ConsoleKey.S)
                {
                    Serialize go = new Serialize(pathq, num);
                }
                else if (tro.Key == ConsoleKey.D)
                {
                    DeSer tr = new DeSer(pathq);
                }
                else if (tro.Key == ConsoleKey.X)
            {
                 Xmle trq = new Xmle(pathq,num);
            }
            
                
            

        }
        }
    }

