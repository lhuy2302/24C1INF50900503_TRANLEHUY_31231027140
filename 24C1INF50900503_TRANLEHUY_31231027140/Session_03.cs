using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24C1INF50900503_TRANLEHUY_31231027140
{
    internal class Session_03
    {
        public static void Main()
        {
            //question03_02();
            //question03_03();
            question03_05();
            Console.ReadKey();
        }
        public static void question03_02()
        //Tính biểu thức x=y^2+2y+1 khi y chạy trong khoảng từ -5 đến 5
        {
            Console.Write("Nhap vao so nguyen y: ");
            int y = int.Parse(Console.ReadLine());
            while (y < -5 || y > 5)
            {
                Console.Write("Nhap lai y: ");
                y = int.Parse(Console.ReadLine());
            }
            {
                Console.WriteLine("So nguyen y ban nhap vao da thoa man yeu cau ");
                int x;
                x = y * y + 2 * y + 1;
                Console.Write($"Vay neu y bang {y} thi x=y*y+2*y+1 bang {x}");
            }
            Console.ReadKey();
        }

        public static void question03_03()
        //Tính vận tốc km/h và miles/h
        {
            //Nhập dữ liệu vào
            Console.Write("Khoang cach la (km): ");
            int d = int.Parse(Console.ReadLine());
            Console.Write("So gio la: ");
            int h = int.Parse(Console.ReadLine());
            Console.Write("So phut la: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("So giay la: ");
            int s = int.Parse(Console.ReadLine());
            //công thức tính vận tốc theo km và miles
            double kmh = (double)d / (h + m / 60 + s / 3600);//có thể viết thêm "f" nếu muốn lấy chính xác hơn: 60f
            double mh = kmh / 1.609344;
            Console.WriteLine($"Van toc tinh theo km la: {kmh} km/h");
            Console.Write($"Van toc tinh theo miles la: {mh} miles/h");
            Console.ReadKey();
        }

        public static void question03_05()
        //Nhập vào kí tự và kiểm tra đó là nguyên âm, chữ số hay kí tự khác
        {
            Console.Write("Nhap vao mot ki tu: ");
            char k = char.Parse(Console.ReadLine());
            //Kiểm tra kí tự có phải số không
            if (char.IsDigit(k))
            {
                Console.WriteLine($"{k} la mot chu so");
            }
            //Kiểm tra kí tự có phải nguyên âm không
            else if (k == 'u' || k == 'U' || k == 'e' || k == 'E' || k == 'o' || k == 'O' || k == 'a' || k == 'A' || k == 'i' || k == 'I')
            {
                Console.WriteLine($"{k} la mot nguyen am");
            }
            else
            {
                Console.WriteLine($"{k} la mot ki tu khac");
            }
            Console.ReadKey();
        }
    }
}
