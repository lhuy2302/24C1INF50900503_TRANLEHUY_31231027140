using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24C1INF50900503_TRANLEHUY_31231027140
{
    internal class Session_05
    {
        //Tìm max
        public static int max(ref int a, ref int b, ref int c)
        {
            int m = 0;
            if (a > b && a > c) m = a;
            else
            {
                if (b > c) m = b;
                else m = c;
            }
            return m;
        }
        //Tìm giai thừa
        public static int GiaiThua(ref int y)
        {
            int gt = 1;
            for (int i = 1; i <= y; i++) gt = gt * i;
            return gt;
        }
        //kiểm tra có phải só nguyên tố hay không
        public static int SoNgTo(ref int y)
        {
            if (y < 2) return 0;
            int dem = 0;
            for (int i = 2; i <= y / 2; i++)
            {
                if (y % i == 0) dem++;
            }
            if (dem == 0) return 1; else return 0;
        }
        //Tìm số nguyên tố trước y
        public static void presnt(ref int y)
        {
            Console.Write($"Cac so nguyen to truoc {y} la: ");
            for (int i = 2; i <= y; i++)
                if (SoNgTo(ref i) == 1) Console.Write(i + " ");
        }
        //Tìm y số nguyên tố dầu tiên
        public static void sntdt(ref int y)
        {
            int n = 2;
            int dem = 0;
            Console.Write($"{y} so nguyen to dau tien la: ");
            while (dem < y)
            {
                if (SoNgTo(ref n) == 1)
                {
                    Console.Write(n + " ");
                    dem++;
                }
                n++;
            }
            Console.WriteLine();
        }
        public static int SoHoanhao(ref int y)
        {
            int z = 0;
            for (int i = 1; i < y; i++)
                if (y % i == 0) z = z + i;
            if (z == y) return 1; else return 0;
        }
        public static void Shhduoi1000()
        {
            Console.Write("Cac so hoan hao duoi 1000 la: ");
            for (int i = 1; i < 1000; i++)
                if (SoHoanhao(ref i) == 1) Console.Write(i + " ");
            Console.WriteLine();
        }
        public static bool Pangram(string chuoi)
        {
            //chuyển chuỗi về dạng chữ thường
            chuoi = chuoi.ToLower();
            //định nghĩa tất cả các chữ cái trong bảng chữ cái tiếng anh
            const string bangChuCai = "abcdefghijklmnopqrstuvwxyz";
            //Kiểm tra xem mỗi kí tự trong bảng chữ cái có xuất hiện trong chuỗi hay không
            return bangChuCai.All(chuoi.Contains);
        }
        public static void Main()
        {
            //Max
            Console.WriteLine("Tim so lon nhat trong cac so: ");
            Console.Write("Nhap so a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhap so c: ");
            int c = int.Parse(Console.ReadLine());
            int m = max(ref a, ref b, ref c);
            Console.WriteLine($"So lon nhat la: {m}");
            Console.WriteLine();

            //Giai Thừa
            Console.WriteLine("Tinh giai thua cua so");
            Console.Write("Nhap so: ");
            int y = int.Parse(Console.ReadLine());
            int gt = GiaiThua(ref y);
            Console.WriteLine($"Giai thua cua {y}: {y}!={gt}");
            Console.WriteLine();

            //Kiểm tra số nguyên tố
            Console.WriteLine("Kiem tra mot so co phai so nguyen to hay khong");
            Console.Write("Nhap mot so: ");
            int y2 = int.Parse(Console.ReadLine());
            if (SoNgTo(ref y2) == 1)
                Console.WriteLine($"{y2} la so nguyen to");
            else
                Console.WriteLine($"{y2} khong phai la so nguyen to");
            Console.WriteLine();

            //In các số nguyên tố trước n và in n số nguyên tố đầu tiên
            Console.WriteLine("In cac so nguyen to");
            Console.Write("Nhap so luong so nguyen to: ");
            int y3 = int.Parse(Console.ReadLine());
            presnt(ref y3);
            Console.WriteLine();
            sntdt(ref y3);
            Console.WriteLine();

            //Kiểm tra 1 số có phải số hoàn hảo và in số hoàn hảo dưới 1000
            Console.WriteLine("Kiem tra mot so co phai so hoan hao hay khong");
            Console.Write("Nhap so: ");
            int y4 = int.Parse(Console.ReadLine());
            if (SoHoanhao(ref y4) == 1) Console.WriteLine($"{y4} la so hoan hao");
            else
                Console.WriteLine($"{y4} khong phai la so hoan hao");
            Shhduoi1000();
            Console.WriteLine();

            //Kiểm tra hàm Pangram
            Console.WriteLine("Chuoi nay co phai là chuoi Pangram khong?");
            Console.Write("Nhap chuoi: ");
            string chuoikiemtra = Console.ReadLine();
            bool ketqua = Pangram(chuoikiemtra);
            Console.WriteLine($"Chuoi nay la pangram dung hay sai? {ketqua}");
        }
    }
}
