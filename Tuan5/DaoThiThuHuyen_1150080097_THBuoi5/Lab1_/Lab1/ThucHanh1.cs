using System;

namespace Lab1
{
    class ThucHanh1
    {
        public static void Run()
        {
            // Thực hành 1: Sử dụng ngôn ngữ lập trình C# để tính và hiển thị chu vi, diện tích của hình chữ nhật có chiều dài a và chiều rộng b được nhập vào từ bàn phím.
            double a, b;

            Console.WriteLine("TINH CHU VI VA DIEN TICH HINH CHU NHAT");
            Console.Write("Nhap chieu dai a: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhap chieu rong b: ");
            b = Convert.ToDouble(Console.ReadLine());

            double chuVi = (a + b) * 2;
            double dienTich = a * b;

            Console.WriteLine("Chu vi: " + chuVi);
            Console.WriteLine("Dien tich: " + dienTich);
        }
    }
}
