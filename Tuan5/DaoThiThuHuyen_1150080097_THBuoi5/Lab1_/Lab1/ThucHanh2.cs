using System;

namespace Lab1
{
    class ThucHanh2
    {
        public static void Run()
        {
            // Thực hành 2: Tìm số lớn hơn trong 2 số nguyên a và b được nhập vào từ bàn phím.
            // Nhap du lieu
            Console.Write("Nhap vao so nguyen a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap vao so nguyen b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            // Tim so max
            int max = 0;
            if (a > b)
            {
                max = a;
            }
            if (b > a)
            {
                max = b;
            }
            if (a == b)
            {
                max = a; // ca hai bang nhau thi max la chinh no
            }

            // Hien thi ket qua
            Console.WriteLine("So lon hon trong 2 so la " + max);
        }
    }
}
