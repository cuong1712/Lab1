using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phan3_bai5
{
    class Program
    {
        struct Luanvan
        {
            public string Maluanvan;
            public string Tenluanvan;
            public string Hoten;
            public string Giangvien;
            public int Namthuchien;
        }
        static void Nhap(out Luanvan L)
        {
            Console.Write("Ma luan van: ");
            L.Maluanvan = Console.ReadLine();
            Console.Write("Ten luan van: ");
            L.Tenluanvan = Console.ReadLine();
            Console.Write("Ho ten: ");
            L.Hoten = Console.ReadLine();
            Console.Write("Giang vien: ");
            L.Giangvien = Console.ReadLine();
            Console.Write("Nam thuc hien: ");
            L.Namthuchien = int.Parse(Console.ReadLine());
        }

        static void Xuat(Luanvan L)
        {
            Console.WriteLine("Ma luan van: " + L.Maluanvan);
            Console.WriteLine("Ten luan van: " + L.Tenluanvan);
            Console.WriteLine("Ho ten: " + L.Hoten);
            Console.WriteLine("Giang vien: " + L.Giangvien);
            Console.WriteLine("Nam thuc hien: " + L.Namthuchien);
        }


        static void Main(string[] args)
        {
            Luanvan L = new Luanvan();
            Console.WriteLine("Nhap thong tin sinh vien: ");
            Nhap(out L);
            Console.WriteLine("***************");
            Console.WriteLine("Thong tin luan van: ");
            Xuat(L);
            Console.ReadLine();
        }
    }
}
