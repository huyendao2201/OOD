using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class ThucHanh7
    {
        public static void Run()
        {
            // Thực hành 7: Viết chương trình nhập vào ba số thực chỉ độ dài của ba đoạn thẳng.Kiểm tra nếu ba đoạn thẳng này lập thành được một tam giá thì hiển thị chu vi và diện tích của tam giác đó.
            // Nhap du lieu
            Console.Write("Nhap do dai canh a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhap do dai canh b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhap do dai canh c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            // Kiem tra dieu kien tam giac
            if (a + b > c && a + c > b && b + c > a)
            {
                double chuVi = a + b + c;
                double p = chuVi / 2; // nua chu vi
                double dienTich = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

                Console.WriteLine("Ba canh tao thanh mot tam giac");
                Console.WriteLine("Chu vi tam giac la " + chuVi);
                Console.WriteLine("Dien tich tam giac la " + dienTich);
            }
            else
            {
                Console.WriteLine("Ba canh khong tao thanh mot tam giac");
            }
        }
    }
}
