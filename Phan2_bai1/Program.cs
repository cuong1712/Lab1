using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phan2_bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap gia tri 3 canh a b c :");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            float S = (a + b + c) / 2;
            if( a + b > c)
            {
                Console.WriteLine("CV= " + (a + b + c));
                Console.WriteLine("DienTich = " + Math.Round(Math.Sqrt(S*(S-a)*(S-b)*(S-c)), 3));
            }
            else
            {
                Console.WriteLine("khong la 3 canh tam giac");
            }
            Console.ReadKey();

        }
    }
}
