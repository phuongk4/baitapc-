using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            QLSVcs qLSVcs = new QLSVcs();

            while (true)
            {
                Console.WriteLine("\nCHUONG TRINH QUAN LY SINH VIEN C#");
                Console.WriteLine("*************************MENU**************************");
                Console.WriteLine("**  1. Them sinh vien.                               **");
                Console.WriteLine("**  2. Cap nhat thong tin sinh vien boi ID.          **");
                Console.WriteLine("**  3. Xoa sinh vien boi ID.                         **");
                Console.WriteLine("**  4. Tim kiem sinh vien theo ten.                  **");
                Console.WriteLine("**  5. Sap xep sinh vien theo diem trung binh (GPA). **");
                Console.WriteLine("**  6. Sap xep sinh vien theo ten.                   **");
                Console.WriteLine("**  7. Sap xep sinh vien theo ID.                    **");
                Console.WriteLine("**  8. Hien thi danh sach sinh vien.                 **");
                Console.WriteLine("**  0. Thoat                                         **");
                Console.WriteLine("*******************************************************");
                Console.Write("Nhap tuy chon: ");
                int key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        Console.WriteLine("\n1. Them sinh vien.");
                        qLSVcs.NhapSinhVien();
                        Console.WriteLine("\nThem sinh vien thanh cong!");
                        break;
                    case 2:
                        if (qLSVcs.SoLuongSinhVien() > 0)
                        {
                            int id;
                            Console.WriteLine("\n2. Cap nhat thong tin sinh vien. ");
                            Console.Write("\nNhap ID: ");
                            id = Convert.ToInt32(Console.ReadLine());
                            qLSVcs.UpdateSinhVien(id);
                        }
                        else
                        {
                            Console.WriteLine("\nSanh sach sinh vien trong!");
                        }
                        break;
                    case 3:
                        if (qLSVcs.SoLuongSinhVien() > 0)
                        {
                            int id;
                            Console.WriteLine("\n3. Xoa sinh vien.");
                            Console.Write("\nNhap ID: ");
                            id = Convert.ToInt32(Console.ReadLine());
                            if (qLSVcs.DeleteById(id))
                            {
                                Console.WriteLine("\nSinh vien co id = {0} da bi xoa.", id);
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nSanh sach sinh vien trong!");
                        }
                        break;
                    case 4:
                        if (qLSVcs.SoLuongSinhVien() > 0)
                        {
                            Console.WriteLine("\n4. Tim kiem sinh vien theo ten.");
                            Console.Write("\nNhap ten de tim kiem: ");
                            string name = Convert.ToString(Console.ReadLine());
                            List<SinhVien> searchResult = qLSVcs.FindByName(name);
                            qLSVcs.ShowSinhVien(searchResult);
                        }
                        else
                        {
                            Console.WriteLine("\nSanh sach sinh vien trong!");
                        }
                        break;
                    case 5:
                        if (qLSVcs.SoLuongSinhVien() > 0)
                        {
                            Console.WriteLine("\n5. Sap xep sinh vien theo diem trung binh (GPA).");
                            qLSVcs.SortByDiemTB();
                            qLSVcs.ShowSinhVien(qLSVcs.getListSinhVien());
                        }
                        else
                        {
                            Console.WriteLine("\nSanh sach sinh vien trong!");
                        }
                        break;
                    case 6:
                        if (qLSVcs.SoLuongSinhVien() > 0)
                        {
                            Console.WriteLine("\n6. Sap xep sinh vien theo ten.");
                            qLSVcs.SortByName();
                            qLSVcs.ShowSinhVien(qLSVcs.getListSinhVien());
                        }
                        else
                        {
                            Console.WriteLine("\nSanh sach sinh vien trong!");
                        }
                        break;
                    case 7:
                        if (qLSVcs.SoLuongSinhVien() > 0)
                        {
                            Console.WriteLine("\n6. Sap xep sinh vien theo ID.");
                            qLSVcs.SortByID();
                            qLSVcs.ShowSinhVien(qLSVcs.getListSinhVien());
                        }
                        else
                        {
                            Console.WriteLine("\nSanh sach sinh vien trong!");
                        }
                        break;
                    case 8:
                        if (qLSVcs.SoLuongSinhVien() > 0)
                        {
                            Console.WriteLine("\n7. Hien thi danh sach sinh vien.");
                            qLSVcs.ShowSinhVien(qLSVcs.getListSinhVien());
                        }
                        else
                        {
                            Console.WriteLine("\nSanh sach sinh vien trong!");
                        }
                        break;
                    case 0:
                        Console.WriteLine("\nBan da chon thoat chuong trinh!");
                        return;
                    default:
                        Console.WriteLine("\nKhong co chuc nang nay!");
                        Console.WriteLine("\nHay chon chuc nang trong hop menu.");
                        break;
                }
            }
        }

    }

}

