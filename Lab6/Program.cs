using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            init();
            Console.ReadLine();
        }
        static void init()
        {
            Triangle triangle1;
            Console.WriteLine("Enter first side of trinagle");
            int AB = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second side of trinagle");
            int BC = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third side of trinagle");
            int CA = int.Parse(Console.ReadLine());
            triangle1 = new Triangle(AB,BC,CA);
            
            Console.WriteLine("You entered: side a={0},side b={1},side c={2}", triangle1.pAB(),triangle1.pBC(), triangle1.pCA());
            
            bool real = triangle1.real_triangle(triangle1);
            Console.WriteLine("Triangle exists ={0}",real);
            if (real == true)
            {
              int tperimeter=  triangle1.triangle_perimeter(triangle1);
                Console.WriteLine("Perimeter ={0}", tperimeter);
                double tS = triangle1.triangle_space(triangle1, tperimeter);
                Console.WriteLine("S of your triangle = {0}", tS);
            }


        }
        

         
        }
    }

