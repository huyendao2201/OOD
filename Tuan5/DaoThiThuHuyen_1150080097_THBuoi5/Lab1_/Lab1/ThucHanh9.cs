using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class ThucHanh9
    {
        public static void Run()
        {
            // Thực hành 9: Tính tổng các phần tử trong mảng.

            Console.Write("Nhap so luong phan tu n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            // Nhap mang
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap phan tu arr[{0}]: ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Tinh tong
            int tong = 0;
            for (int i = 0; i < n; i++)
            {
                tong += arr[i];
            }

            // Hien thi ket qua
            Console.WriteLine("Tong cac phan tu trong mang la " + tong);
        }
    }
}
