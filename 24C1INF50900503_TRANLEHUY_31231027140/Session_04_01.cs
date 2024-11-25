using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24C1INF50900503_TRANLEHUY_31231027140
{
    internal class Session_04_01
    {
        public static void Main()
        {
            //session04_01();
            //session04_02();
            //session04_03();
            Console.ReadKey();
        }
        public static void session04_01()
        {
            //check whether a given number is even or odd
            int a;
            Console.Write("Nhap vao so a: ");
            a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
                Console.WriteLine("{0} la so chan", a);
            else
                Console.WriteLine("{0} la so le", a);
            Console.ReadKey();
        }
        public static void session04_02()
        {
            //find the largest of three numbers
            int num1, num2, num3;
            int max;
            Console.Write("Nhap vao so thu nhat: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao so thu hai: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao so thu ba: ");
            num3 = int.Parse(Console.ReadLine());
            if (num1 >= num2 && num1 >= num3)
                Console.Write("So lon nhat trong ba so la so thu nhat: " + num1);
            if (num2 >= num1 && num2 >= num3)
                Console.Write("So lon nhat trong ba so la so thu hai: " + num2);
            if (num3 >= num1 && num3 >= num2)
                Console.Write("So lon nhat trong ba so la so thu ba: " + num3);
            Console.ReadKey();

        }
        public static void session04_03()
        {
            //accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies.
            int x, y;
            Console.Write("Nhap hoanh do: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Nhap tung do: ");
            y = int.Parse(Console.ReadLine());
            if (x > 0 && y > 0)
                Console.WriteLine("Cap toa do {0},{1} thuoc goc phan tu thu nhat", x, y);
            else if (x < 0 && y > 0)
                Console.WriteLine("Cap toa do {0},{1} thuoc goc phan tu thu hai", x, y);
            else if (x < 0 && y < 0)
                Console.WriteLine("Cap toa do {0},{1} thuoc goc phan tu thu ba", x, y);
            else if (x > 0 && y < 0)
                Console.WriteLine("Cap toa do {0},{1} thuoc goc phan tu thu tu", x, y);
            else if (x == 0 && y == 0)
                Console.WriteLine("Cap toa do {0},{1} la goc toa do", x, y);
            Console.ReadKey();

        }
    }
}
