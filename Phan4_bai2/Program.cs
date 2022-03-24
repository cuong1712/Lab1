using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phan4_bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            float[] a = new float[n];
            float sum = 0;
            for (int i = 0; i < n; i++)
            {
                if(a[i] < 0)
                {
                    sum += a[i];
                }
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
