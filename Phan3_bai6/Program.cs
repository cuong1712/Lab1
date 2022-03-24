using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phan3_bai6
{
    class Program
    {
        struct Hopsua 
        { 
            public string Nhanhieu;
            public float Trongluong;
            public string Han;
        }

        static void Nhap(out Hopsua H)
        {
            Console.Write("Ten nhan hieu: ");
            H.Nhanhieu = Console.ReadLine();
            Console.Write("Trong luong san pham: ");
            H.Trongluong = float.Parse(Console.ReadLine());
            Console.Write("Han su dung: ");
            H.Han = Console.ReadLine();
        }

        static void Xuat(Hopsua H)
        {
            Console.WriteLine("Ten nhan hieu: " + H.Nhanhieu);
            Console.WriteLine("Trong luong san pham: " + H.Trongluong);
            Console.WriteLine("Han su dung: " + H.Han);
        }

        static void Main(string[] args)
        {
            Hopsua H = new Hopsua();
            Console.WriteLine("Nhap thong tin hop sua: ");
            Nhap(out H);
            Console.WriteLine("*******************");
            Console.WriteLine("Thong tin hop sua: ");
            Xuat(H);
            Console.ReadKey();
        }
    }
}
