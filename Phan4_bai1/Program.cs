using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phan4_bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so phan tu cho arr : ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int answer = 0;
            
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                for ( int j = 2; j < 10; j++)
                {   
                    if(arr[i] % j == 0 || arr[i] > 100)
                    {
                        break; 
                    }
                    else
                    {
                        answer = answer + 1;
                        break;
                    }
                }
            }
            Console.WriteLine("So Nguyen To:" + answer);
            Console.ReadKey();
        }
    }
}
