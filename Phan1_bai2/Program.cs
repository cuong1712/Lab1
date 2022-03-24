using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap diem mon Toan");
            float toan = float.Parse(Console.ReadLine());

            Console.WriteLine("Nhap diem mon Van");
            float van = float.Parse(Console.ReadLine());

            Console.WriteLine("Nhap diem mon Ly");
            float ly = float.Parse(Console.ReadLine());

            Console.WriteLine("Nhap diem mon Hoa");
            float hoa = float.Parse(Console.ReadLine());

            Console.WriteLine("Nhap diem mon Sinh");
            float sinh = float.Parse(Console.ReadLine());

            Console.WriteLine("Nhap diem mon Anh");
            float anh = float.Parse(Console.ReadLine());

            Console.WriteLine("Toan: " + toan);
            Console.WriteLine("Van: " + van);
            Console.WriteLine("Ly: " + ly);
            Console.WriteLine("Hoa: " + hoa);
            Console.WriteLine("Sinh" + sinh);
            Console.WriteLine("Anh: " + anh);
            Console.WriteLine("TB = " + (toan*3 + van*2 + ly*2 + anh*2 + sinh + hoa)/11);
            Console.ReadKey();

        }
    }
}
