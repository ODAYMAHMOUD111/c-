using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (char a = 'a'; a <= 'z'; a++) 
            {
                Console.WriteLine(a);
            }
        for (int i = 1; i <=4; i++) {
                for (int j = 4; j >=i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
    
}
