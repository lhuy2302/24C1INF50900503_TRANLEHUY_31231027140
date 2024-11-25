using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24C1INF50900503_TRANLEHUY_31231027140
{
    internal class Session_06_02
    {
        //Tạo mảng ngẫu nhiên
        public static int[] TaoMangNgauNhien(int kichthuoc, int s1, int s2)
        {
            int[] a = new int[kichthuoc];
            Random rnd = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(s1, s2 + 1);
            }
            return a;
        }

        //Hàm tính giá trị trung bình của các phần tử
        public static float TrungBinh(int[] a)
        {
            float tb;
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            tb = (float)sum / a.Length;
            return tb;
        }

        //Hàm kiểm tra mảng có chưa một giá trị cụ thể hay không
        public static bool Kiemtra(int[] a1, int value)
        {
            foreach (int i in a1)
            {
                if (i == value) return true;
            }
            return false;
        }

        //Hàm tìm chỉ số của một phần tử mảng
        public static int Timchiso(int[] a2, int value2)
        {
            for (int i = 0; i < a2.Length; i++)
            {
                if (a2[i] == value2) return i;
            }
            return -1;
        }

        //Hàm xóa một phần tử cụ thể khỏi mảng
        public static int[] Xoaphantu(int[] a3, int giatri)
        {
            int index = Array.IndexOf(a3, giatri);
            if (index == -1)
            {
                Console.WriteLine($"Gia tri {giatri} khong ton tai trong mang");
                return a3;
            }
            int[] mangmoi = new int[a3.Length - 1];
            Array.Copy(a3, 0, mangmoi, 0, index);
            Array.Copy(a3, index + 1, mangmoi, index, a3.Length - index - 1);
            return mangmoi;
        }

        //Hàm tìm giá trị lớn nhất trong mảng
        public static int Timmax(int[] a4)
        {
            int max = a4[0];
            for (int i = 1; i < a4.Length; i++)
            {
                int n = a4[i];
                if (n > max) max = n;
            }
            return max;
        }

        //Hàm tìm giá trị nhỏ nhất trong mảng
        public static int Timmin(int[] a5)
        {
            int min = a5[0];
            foreach (int giatri in a5)
                if (giatri < min)
                {
                    min = giatri;
                }
            return min;
        }

        //Hàm đảo ngược mảng
        public static void Daonguocmang(int[] a6)
        {
            int left = 0;
            int right = a6.Length - 1;
            while (left < right)
            {
                int temp = a6[left];
                a6[left] = a6[right];
                a6[right] = temp;
                left++;
                right--;
            }
        }

        //Hàm tìm giá trị trùng lặp
        public static void laplai(int[] a7)
        {
            Array.Sort(a7);
            int temp = 0;
            Console.WriteLine("Cac phan tu bi lap lai: ");
            for (int i = 0; i < a7.Length; i++)
            {
                for (int j = 0; j < a7.Length; j++)
                {
                    if (a7[i] != temp)
                    {
                        if (a7[j] == a7[i])
                        {
                            Console.WriteLine(a7[i] + "\t");
                        }
                    }
                    break;
                }
                temp = a7[i];
            }
            Console.WriteLine();
        }

        //Hàm xóa giá trị trùng lặp
        public static void xoalaplai(int[] a8)
        {
            int[] x11 = a8.Distinct().ToArray();
            Console.WriteLine("Mang sau khi xoa cac phan tu lap lai: ");
            {
                for (int i = 0; i < x11.Length; i++)
                    Console.Write(x11[i] + "\t");
            }
        }
        public static void Main()
        {
            Console.WriteLine("Nhap mang");
            Console.Write("Nhap kich thuoc mang: ");
            int kichthuoc = int.Parse(Console.ReadLine());
            Console.Write("Nhap gia tri nho nhat: ");
            int min = int.Parse(Console.ReadLine());
            Console.Write("Nhap gia tri lon nhat: ");
            int max = int.Parse(Console.ReadLine());
            //Tạo mảng ngẫu nhiên
            int[] mangngaunhien = TaoMangNgauNhien(kichthuoc, min, max);
            //In mảng ngẫu nhiên
            Console.WriteLine("Mang ngau nhien la: ");
            foreach (int i in mangngaunhien)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();

            Console.WriteLine("TINH GIA TRI TRUNG BINH");
            float tb = TrungBinh(mangngaunhien);
            Console.WriteLine($"Gia tri trung binh cua mang la: {tb} ");
            Console.WriteLine();

            Console.WriteLine("KIEM TRA GIA TRI TRONG MANG: ");
            Console.Write("Nhap gia tri: ");
            int giatricantim = int.Parse(Console.ReadLine());
            bool b = Kiemtra(mangngaunhien, giatricantim);
            if (b)
            {
                Console.WriteLine($"Mang co chua {giatricantim}");
            }
            else
            {
                Console.WriteLine($"Mang khong chua {giatricantim}");
            }
            Console.WriteLine();

            Console.WriteLine("TIM CHI SO CUA PHAN TU MANG");
            int chiso = Timchiso(mangngaunhien, giatricantim);
            if (chiso != -1)
            {
                Console.WriteLine($"Gia tri {giatricantim} o tai chi so {chiso}");
            }
            else
                Console.WriteLine($"Gia tri {giatricantim} khong ton tai trong mang");
            Console.WriteLine();

            Console.WriteLine("XOA PHAN TU TRONG MANG");
            Console.WriteLine("Nhap gia tri can xoa khoi mang: ");
            int giatricanxoa = int.Parse(Console.ReadLine());
            int[] mangsaukhixoa = Xoaphantu(mangngaunhien, giatricanxoa);
            Console.WriteLine("Mang sau khi xoa phan tu: ");
            foreach (int giatri in mangsaukhixoa)
            {
                Console.Write(giatri + "\t");
            }
            Console.WriteLine();

            Console.WriteLine("TIM MAX MIN CUA MANG");
            int lonnhat = Timmax(mangngaunhien);
            int nhonhat = Timmin(mangngaunhien);
            Console.WriteLine($"Gia tri lon nhat trong mang: {lonnhat}");
            Console.WriteLine($"Gia tri nho nhat trong mang: {nhonhat}");
            Console.WriteLine();

            Console.WriteLine("DAO NGUOC MANG");
            Daonguocmang(mangngaunhien);
            Console.WriteLine("Mang sau khi dao nguoc la: ");
            foreach (int giatri in mangngaunhien)
            {
                Console.WriteLine(giatri + "\t");
            }
            Console.WriteLine();

            Console.WriteLine("IN PHAN TU LAP LAI");
            laplai(mangngaunhien);
            Console.WriteLine();

            Console.WriteLine("XOA CAC PHAN TU LAP LAI");
            xoalaplai(mangngaunhien);
            Console.WriteLine();

            Console.ReadKey();

        }
    }
}
