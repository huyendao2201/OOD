using Lab1;
using System;

namespace ThucHanh
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== CHUONG TRINH THUC HANH C# ===");
                Console.WriteLine("1. Thuc hanh 1: Chu vi va dien tich hinh chu nhat");
                Console.WriteLine("2. Thuc hanh 2: Tim so lon hon trong hai so nguyen");
                Console.WriteLine("3. Thuc hanh 3: Tim so lon nhat trong ba so nguyen");
                Console.WriteLine("4. Thuc hanh 4: Cho biet mot thang co bao nhieu ngay");
                Console.WriteLine("5. Thuc hanh 5: Kiem tra so chan le va am khong am");
                Console.WriteLine("6. Thuc hanh 6: Chu vi va dien tich hinh chu nhat (so thuc)");
                Console.WriteLine("7. Thuc hanh 7: Kiem tra tam giac va tinh chu vi dien tich");
                Console.WriteLine("8. Thuc hanh 8: Giai phuong trinh bac 2");
                Console.WriteLine("9. Thuc hanh 9: Tinh tong cac phan tu trong mang");
                Console.WriteLine("10. Thuc hanh 10: Sap xep mang bang Selection Sort (doc tu file)");
                Console.WriteLine("11. Thuc hanh 11: Chen mot so vao mang da sap xep tang dan");
                Console.WriteLine("0. Thoat");
                Console.Write("Nhap lua chon: ");

                int choice;
                bool ok = int.TryParse(Console.ReadLine(), out choice);
                if (!ok) choice = -1;

                Console.Clear();

                if (choice == 1)
                    ThucHanh1.Run();
                else if (choice == 2)
                    ThucHanh2.Run();
                else if (choice == 3)
                    ThucHanh3.Run();
                else if (choice == 4)
                    ThucHanh4.Run();
                else if (choice == 5)
                    ThucHanh5.Run();
                else if (choice == 6)
                    ThucHanh6.Run();
                else if (choice == 7)
                    ThucHanh7.Run();
                else if (choice == 8)
                    ThucHanh8.Run();
                else if (choice == 9)
                    ThucHanh9.Run();
                else if (choice == 10)
                    ThucHanh10.Run();
                else if (choice == 11)
                    ThucHanh11.Run();
                else if (choice == 0)
                    break;
                else
                    Console.WriteLine("Khong co lua chon nay");

                Console.WriteLine();
                Console.WriteLine("Nhan phim bat ky de tiep tuc...");
                Console.ReadKey();
            }
        }
    }
}
