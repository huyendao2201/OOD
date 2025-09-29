using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class ThucHanh6
    {
        public static void Run()
        {
            // Thực hành 6: Viết chương trình nhập vào 2 số thực dương chỉ chiều dài và chiều rộng của hình chữ nhật.In ra màn hình chu vi và diện tích của hình chữ nhật đó.

            // Nhap du lieu
            Console.Write("Nhap vao chieu dai: ");
            double dai = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhap vao chieu rong: ");
            double rong = Convert.ToDouble(Console.ReadLine());

            if (dai <= 0 || rong <= 0)
            {
                Console.WriteLine("Chieu dai va chieu rong phai lon hon 0");
                return;
            }

            // Tinh toan
            double chuVi = (dai + rong) * 2;
            double dienTich = dai * rong;

            // Hien thi ket qua
            Console.WriteLine("Chu vi hinh chu nhat la " + chuVi);
            Console.WriteLine("Dien tich hinh chu nhat la " + dienTich);
        }
    }
}
