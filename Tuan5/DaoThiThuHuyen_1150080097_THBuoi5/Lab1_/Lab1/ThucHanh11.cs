using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class ThucHanh11
    {
        public static void Run()
        {
            /*
             * Thực hành 11: Chèn thêm một số nguyên được nhạp vào từ bàn phím vào mảng
            đã sắp xếp tăng dần nhưng không làm mất tính tăng dần của mảng.
             */

            Console.Write("Nhap so luong phan tu n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap phan tu arr[{0}]: ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Sap xep mang truoc
            Array.Sort(arr);

            Console.Write("Nhap so can chen: ");
            int x = Convert.ToInt32(Console.ReadLine());

            int[] newArr = new int[n + 1];
            int k = 0;
            bool daChen = false;

            for (int i = 0; i < n; i++)
            {
                if (!daChen && x < arr[i])
                {
                    newArr[k++] = x;
                    daChen = true;
                }
                newArr[k++] = arr[i];
            }
            if (!daChen)
            {
                newArr[k] = x;
            }

            // Hien thi mang moi
            Console.WriteLine("Mang sau khi chen:");
            foreach (int val in newArr)
            {
                Console.Write(val + " ");
            }
            Console.WriteLine();
        }
    }
}
