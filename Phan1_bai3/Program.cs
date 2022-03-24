using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            float x = float.Parse(Console.ReadLine());
            Console.WriteLine("y1 = 2x3 + 5x2 + 7x +15 = " + (2*Math.Pow(x,3) + 5*Math.Pow(x,2) + 7*x + 15));
            Console.WriteLine("y2 = sin^2(x) + cos^2(2x) + tan^2(3x) = " + (Math.Pow(Math.Sin(x),2)) + Math.Pow(Math.Cos(2*x),2) + Math.Pow(Math.Tan(3*x),2));
            Console.WriteLine("y3 = (x+10)^(x+5) = " + (Math.Pow((x + 5), x+2)));
            Console.WriteLine("y4 = 3e^cos(x+1) =  " + 3*Math.Exp(Math.Cos(x+1)));
            Console.WriteLine("y5 = log(x + 100)" + Math.Log(x+100));
            Console.ReadKey();
        }
    }
}
