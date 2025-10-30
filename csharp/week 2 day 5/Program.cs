using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char choice;
            do
            {
                float grade1, grade2, grade3, average;
                Console.WriteLine("enter  student grades");
                grade1 = float.Parse(Console.ReadLine());
                grade2 = float.Parse(Console.ReadLine());
                grade3 = float.Parse(Console.ReadLine());
                average = (grade1 + grade2 + grade3) / 3;
                if (average >= 50)

                    Console.WriteLine("pass");

                else

                    Console.WriteLine("fail");



                if (average >= 90)

                    Console.WriteLine("excellent");


                else if (average >= 80)

                    Console.WriteLine("very good");


                else if (average >= 70)

                    Console.WriteLine("good");

                else if (average >= 60)

                    Console.WriteLine("fair");


                else Console.WriteLine("weak");
                Console.WriteLine();
                Console.WriteLine("do you want to calculate another student ");
                choice = Convert.ToChar(Console.ReadLine());
            } while (choice == 'y');

            Console.WriteLine("program ended");

            

              

          

           





        }
         
    }

}
