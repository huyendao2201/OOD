using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class ThucHanh3
    {
        public static void Run()
        {
            //Thực hành 3: Tìm số có giá trị lớn nhất trong 3 số nguyên a, b, c được nhập vào từ bàn phím.

            // Nhap du lieu
            Console.Write("Nhap vao so nguyen a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap vao so nguyen b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap vao so nguyen c: ");
            int c = Convert.ToInt32(Console.ReadLine());

            // Tim so max
            int max = a;
            if (b > max)
            {
                max = b;
            }
            if (c > max)
            {
                max = c;
            }

            // Hien thi ket qua
            Console.WriteLine("So lon nhat trong 3 so la {0}", max);
        }
    }
}
