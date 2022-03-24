using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phan3_bai7
{
    class Program
    {
        static bool CP(int n)
        {
            int sqr = (int)Math.Sqrt(n);
            if (sqr * sqr == n)
            {
                return true;
            }
            else return false;
        }
        

        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao so nguyen n: ");
            int n = int.Parse(Console.ReadLine());
            if (CP(n))
            {
                Console.WriteLine("So {0} la so chinh phuong.", n);
            }
            else
            {
                Console.WriteLine("So {0} khong la so chinh phuong.", n);
            }
            Console.ReadKey();
        }
    }
}
