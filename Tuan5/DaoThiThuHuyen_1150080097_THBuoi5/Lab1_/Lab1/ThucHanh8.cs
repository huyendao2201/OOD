using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class ThucHanh8
    {
        public static void Run()
        {
            // Thực hành 8: Viết chương trình giải phương trình bậc 2: ax2 + bx + c = 0.
            // Nhap du lieu
            Console.Write("Nhap he so a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhap he so b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhap he so c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }
                else
                {
                    double x = -c / b;
                    Console.WriteLine("Phuong trinh co mot nghiem la x = " + x);
                }
            }
            else
            {
                double delta = b * b - 4 * a * c;
                if (delta < 0)
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }
                else if (delta == 0)
                {
                    double x = -b / (2 * a);
                    Console.WriteLine("Phuong trinh co nghiem kep x = " + x);
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("Phuong trinh co hai nghiem");
                    Console.WriteLine("x1 = " + x1);
                    Console.WriteLine("x2 = " + x2);
                }
            }
        }
    }
}
