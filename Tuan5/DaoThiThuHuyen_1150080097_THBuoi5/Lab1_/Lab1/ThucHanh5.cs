using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class ThucHanh5
    {
        public static void Run()
        {
            // Thực hành 5: Viết chương trình nhập vào một số nguyên n. Cho biết: a) n là số chẵn hay số lẻ? b) n là số âm hay số không âm?
            // Nhap du lieu
            Console.Write("Nhap vao so nguyen n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            // a) Kiem tra chan le
            if (n % 2 == 0)
            {
                Console.WriteLine("n la so chan");
            }
            else
            {
                Console.WriteLine("n la so le");
            }

            // b) Kiem tra am hay khong am
            if (n < 0)
            {
                Console.WriteLine("n la so am");
            }
            else
            {
                Console.WriteLine("n la so khong am");
            }
        }
    }
}
