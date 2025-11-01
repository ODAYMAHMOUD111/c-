using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
              char choice;
              do
              {
                  Console.WriteLine("please enter your grade");
                  float grade = float.Parse(Console.ReadLine());
                  string result = grade >= 50 ? "passed" : "failed";
                  Console.WriteLine(result);
                  Console.WriteLine("do you want calculate another student result y/n");
                  choice = char.Parse(Console.ReadLine());
              } while (choice == 'y');
              Console.WriteLine("program ended");
            
            double value = 1000D / 12.34D;
            Console.WriteLine("{0:f2}", value);
            Console.WriteLine(string.Format("{0:0}", value));
            Console.WriteLine(string.Format("{0:0.0}", value));
            Console.WriteLine(string.Format("{0:0.00}", value));
            double money = 100 / 3D; 
            Console.WriteLine(string.Format("{0:0.#}", money));

          
        }
    }
}
