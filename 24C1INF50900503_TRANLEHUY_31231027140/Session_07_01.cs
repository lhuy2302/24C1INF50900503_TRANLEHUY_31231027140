using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24C1INF50900503_TRANLEHUY_31231027140
{
    internal class Session_07_01
    {
        static void NhapMangBangCom(int[,] a, int rows, int columns)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"a[{i},{j}] = ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }

        }
        static void NhapMangNgauNhien(int[,] a, int rows, int columns)
        {
            Random random = new Random();
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"a[{i},{j}] = ");
                    a[i, j] = random.Next(0, 100);
                }
            }
        }
        static void XuatMang(int[,] a)
        {
            //int[,] b =
            //{
            //   { 1, 2, 3 },
            //    { 4, 5, 6 }
            //};
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void SearchLinear(int[,] a, int value)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] == value)
                    {
                        Console.WriteLine($"{value} xuat hien tai dong {i} cot {j}\n");
                        //return;//neu co 1 gia tri
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[,] a;
            Console.Write("Nhap so dong: "); int rows = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot: "); int cols = int.Parse(Console.ReadLine());
            //tao mang 2 chieu
            a = new int[rows, cols];
            //NhapMangBangCom
            NhapMangNgauNhien(a, rows, cols);
            XuatMang(a);
            Console.Write("Nhap so can tim: "); int val = int.Parse(Console.ReadLine());
            SearchLinear(a, val);
        }
    }
}
