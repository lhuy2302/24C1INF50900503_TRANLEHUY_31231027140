using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24C1INF50900503_TRANLEHUY_31231027140
{
    internal class Session_04_02
    {
        public static void Main()
        {
            //Session04_02_01();
            //Session04_02_02();
            //Session04_02_03();
            //Session04_02_04();
            //Session04_02_05();
            //Session04_02_06();
            //Session04_02_07();
            //Session04_02_08();
            Console.ReadKey();
        }
        public static void Session04_02_01()
        {
            //Write a program to check whether a triangle is Equilateral, Isosceles or Scalene.
            float x, y, z;
            Console.Write("Do dai canh thu nhat: ");
            x = float.Parse(Console.ReadLine());
            Console.Write("Do dai canh thu hai: ");
            y = float.Parse(Console.ReadLine());
            Console.Write("Do dai canh thu ba: ");
            z = float.Parse(Console.ReadLine());
            //kiểm tra xem có tạo thành tam giác hay không
            if (x + y > z && x + z > y && y + z > x)
            {
                if (x == y && y == z)
                    Console.WriteLine("Tam giac do la tam giac deu");
                else if (x == y || y == z || x == z)
                    Console.WriteLine("Tam giac do la tam giac can");
                else
                    Console.WriteLine("Tam giac do la tam giac thuong");
            }
            else
                Console.WriteLine("Ba canh nay khong tao thanh tam giac");
            Console.ReadKey();
        }
        public static void Session04_02_02()
        {
            //Write a program to read 10 numbers and find their average and sum.
            double sum = 0;
            int count = 10;
            // vòng lặp nhập 10 số từ bàn phím
            for (int i = 1; i <= count; i++)
            {
                Console.Write($"Nhap so thu {i}: ");
                double number = double.Parse(Console.ReadLine());
                //cộng giá trị vào tổng
                sum += number;
            }
            //tính trung bình
            double average = sum / count;
            Console.WriteLine("Tong cua 10 so la: {0}", sum);
            Console.WriteLine("Trung binh cong cua 10 so la: {0}", average);
            Console.ReadKey();
        }
        public static void Session04_02_03()
        {
            //Write a program to display the multiplication table of a given integer (bảng cửu chương)
            int count = 10;
            int a;
            Console.Write("Nhap vao mot so: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Bang cuu chuong cua {0} la: ", a);
            for (int i = 1; i <= count; i++)
            {
                int kq = a * i;
                Console.WriteLine($"{a}*{i} = {kq}");
            }
            Console.ReadKey();
        }
        public static void Session04_02_04()
        {
            //Write a program to display a pattern like triangles with a number

        }
        public static void Session04_02_05()
        {
            //Write a program to display a pattern like triangles with a number - tam giác vuông lặp lại, liên tục, cân
            Console.Write("Nhap so dong: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine();
            //tam giác vuông có số lặp lại
            Console.WriteLine("Tam giac vuong so lap lai: ");
            int i, j;
            for (i = 1; i <= a; i++)
            {
                for (j = 1; j <= i; j++) Console.Write(j + " ");
                Console.WriteLine();
            }
            Console.WriteLine();

            //tam giác vuông có số liên tuc
            Console.WriteLine("Tam giac vuong co so lien tuc: ");
            int b = 1;
            for (i = 1; i <= a; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(b + " ");
                    b++;
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            //tam giác cân có số liên tục
            Console.WriteLine("Tam giac can co so lien tuc: ");
            int c = 1;
            for (i = 1; i <= a; i++)
            {
                for (int space = 1; space <= a - i; space++)
                    Console.Write(" ");
                for (j = 1; j <= i; j++)
                {
                    Console.Write(c + " ");
                    c++;
                }
                Console.WriteLine();
            }

        }
        public static void Session04_02_06()
        {
            //Write a program to display the n terms of harmonic series and their sum. 1 + 1 / 2 + 1 / 3 + 1 / 4 + 1 / 5... 1 / n terms
            //dãy điều hòa
            int n;
            Console.Write("Nhap so luong so hang: ");
            n = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                double a = 1 / i;
                sum += a;
                Console.WriteLine("1/" + i);
                if (i < n)
                    Console.Write(" + ");
            }
            Console.WriteLine("Tong cua day dieu hoa tren la: {0}", sum);
            Console.ReadKey();
        }
        public static void Session04_02_07()
        {
            //find the ‘perfect’ numbers within a given number range - số hoàn hảo (các ước cộng lại bằng chính nó
            Console.Write("Nhap mot so: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            for (int i = 1; i < a; i++) if (a % i == 0) b = b + i;
            Console.WriteLine($"Tong cac uoc cua {a} = {b}");
            if (b == a) Console.WriteLine($"{a} la so hoan hao");
            else Console.WriteLine($"{a} khong phai la so hoan hao");

        }
        public static void Session04_02_08()
        {
            //determine whether a given number is prime or not. - số nguyên tố (có ước là 1 và chính nó)
            Console.Write("Nhap so vao: ");
            int a = int.Parse(Console.ReadLine());
            int b = 0;
            for (int i = 1; i <= a; i++)
                if (a % i == 0) b++;
            if (b == 2) Console.WriteLine($"{a} la so nguyen so");
            else Console.WriteLine($"{a} khong phai la so nguyen to");
            Console.ReadKey();
        }
    }
}
