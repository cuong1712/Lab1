using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ham
{
    class Program
    {
        static bool Check(int x)
        {
            if (x < 2)
            {
                return false;
            }
            for (int i = 1; i < Math.Sqrt(x); i++)
            {
                if (x / i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Nhap(int[] a, int sl)
        {
            for (int i = 0; i < sl; i++)
            {
                Console.WriteLine("Nhap so nguyen: ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        static int Dem(int[] a, int sl)
        {
            int count = 0;
            for (int i = 0; i < sl; i++)
            {
                if (Check(a[i]) == true && a[i] < 100)
                {
                    count++;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            int[] a = new int[200];
            Console.WriteLine("Nhap so luong so nguyen: ");
            int sl = int.Parse(Console.ReadLine());
            Nhap(a, sl);
            Console.WriteLine("So so nguyen to nho hon 100: " + Dem(a, sl));
            Console.ReadKey();
        }
    }
}
