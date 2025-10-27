using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter the number");
            int number;
                number = int.Parse(Console.ReadLine());
            if (number %2 == 0)
            {
                Console.WriteLine("The number is even");

            }
            else  { 
                Console.WriteLine("the number is odd");
            }




                Console.WriteLine("enter your grade");
            string grade = Console.ReadLine();
            
            
                
            
            switch (grade)
            {
                case "A":
                    Console.WriteLine("excellent");
                    break;
                case "B":
                    Console.WriteLine("very good");
                    break;
                    case "C": Console.WriteLine("good");
                    break;
                    case "D": Console.WriteLine("Pass");
                    break;
                case "F": Console.WriteLine("fail");
                    break;
                    default: Console.WriteLine("invalid grade");
                    break;
            }
        }
    }
}
