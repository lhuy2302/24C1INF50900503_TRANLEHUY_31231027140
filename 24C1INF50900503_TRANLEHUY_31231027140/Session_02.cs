using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24C1INF50900503_TRANLEHUY_31231027140
{
    internal class Session_02
    {
        public static void Main()
        {
            //ex_01();
            //ex_02();
            //ex_03();
            Console.ReadKey();
        }
        public static void ex_01()
        {
            //đổi độ C sang độ K và độ F
            Console.Write("Nhap vao do C: ");
            float c = float.Parse(Console.ReadLine());
            double k = c + 273;
            double f = c * 18 / 10 + 32;
            Console.WriteLine($"Chuyen thanh do K: {k}");
            Console.WriteLine($"Chuyen thanh do F: {f}");
        }
        public static void ex_02()
        {
            //tính diện tích bề mặt và thể tích
            Console.Write("Nhap vao ban kinh: ");
            float a = float.Parse(Console.ReadLine());
            double pi = Math.PI;
            double s = 4 * pi * Math.Pow(a, 2);
            double v = 4 / 3 * pi * Math.Pow(a, 3);
            Console.WriteLine($"Dien tich be mat la: {s}");
            Console.WriteLine($"The tich la: {v}");
        }
        public static void ex_03()
        {
            Console.Write("Nhap vao so thu nhat: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Nhap vao so thu hai: ");
            float b = float.Parse(Console.ReadLine());
            double cong = a + b;
            double tru = a - b;
            double nhan = a * b;
            double chia = a / b;
            double chiadu = a % b;
            Console.WriteLine($"Tong 2 so: {cong}");
            Console.WriteLine($"Hieu 2 so: {tru}");
            Console.WriteLine($"Tich 2 so: {nhan}");
            Console.WriteLine($"Thuong 2 so (nguyen): {chia}");
            Console.WriteLine($"Thuong 2 so (du): {chiadu}");
        }
    }
}
