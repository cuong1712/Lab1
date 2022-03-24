using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phan2_bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap toa do x1, y1 : ");
            float x1 = float.Parse(Console.ReadLine());
            float y1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Nhap toa do x2, y2 : ");
            float x2 = float.Parse(Console.ReadLine());
            float y2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Toa do TD (x) :" + (x1 + x2) / 2);
            Console.WriteLine("Toa do TD (x) :" + (y1 + y2) / 2);
            Console.WriteLine("d = " + Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2),2)));
            Console.ReadKey();
        }
    }
}
