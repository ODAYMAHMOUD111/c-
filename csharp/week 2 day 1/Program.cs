using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float radius, area;
            const float pi = 3.14f;
            Console.WriteLine("enter the radius of ball ");
             radius = Convert.ToSingle(Console.ReadLine());
            area = 4*pi*radius*radius;
            Console.WriteLine("the area of ball = {0} ", area);
          





        }  
    }
}
