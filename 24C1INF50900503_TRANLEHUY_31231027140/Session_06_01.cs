using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24C1INF50900503_TRANLEHUY_31231027140
{
    internal class Session_06_01
    {
        public static void Main2()
        {
            Console.Write("Nhap N: "); //khai báo mảng
            int N = int.Parse(Console.ReadLine());
            int[] a = new int[N];
            //Nhập dữ liệu
            Console.WriteLine("Nhap du lieu day: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write($"Nhap phan tu {i + 1}: ");
                a[i] = int.Parse(Console.ReadLine());
            }
            //in mảng ban đầu
            Console.WriteLine("Mang ban dau: ");
            PrintArray(a);
            //Tăng mỗi phần tử lên 2
            IncreaseArrayItems(a);
            Console.WriteLine("Mang sau khi tang 2: ");
            PrintArray(a);
        }
        static void PrintArray(int[] a)
        {
            foreach (int item in a)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        static void IncreaseArrayItems(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] += 2;
            }
        }
    }
}
