using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class ThucHanh10
    {
        public static void Run()
        {
            /*
             Thực hành 10: Dùng giải thuật sắp xếp chọn (Selection Sort) để sắp xếp tăng
            dần mảng các số nguyên. Mảng các số nguyên được lưu trong tệp văn bản có tên
            là “input_array.txt”.
            */

            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "input_array.txt");


            if (!File.Exists(filePath))
            {
                Console.WriteLine("Khong tim thay file input_array.txt");
                return;
            }

            string[] lines = File.ReadAllLines(filePath);
            int[] arr = Array.ConvertAll(lines, int.Parse);

            // Selection Sort
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                // Doi cho
                int temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }

            // Hien thi ket qua
            Console.WriteLine("Mang sau khi sap xep tang dan:");
            foreach (int x in arr)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();

            // Ghi lai file ket qua
            File.WriteAllLines("output_array.txt", Array.ConvertAll(arr, x => x.ToString()));
            Console.WriteLine("Da ghi ket qua vao file output_array.txt");
        }
    }
}
