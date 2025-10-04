using System;

class Program
{
    static int[,] TaoMaTran(int n, int m, int min = 0, int max = 100)
    {
        Random rand = new Random();
        int[,] a = new int[n, m];
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
                a[i, j] = rand.Next(min, max + 1);
        return a;
    }

    static void XuatMaTran(int[,] a)
    {
        int n = a.GetLength(0);
        int m = a.GetLength(1);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
                Console.Write(a[i, j] + " ");
            Console.WriteLine();
        }
    }

    static (int maxVal, int minVal) TimMaxMin(int[,] a)
    {
        int n = a.GetLength(0), m = a.GetLength(1);
        int maxVal = a[0, 0], minVal = a[0, 0];
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
            {
                if (a[i, j] > maxVal) maxVal = a[i, j];
                if (a[i, j] < minVal) minVal = a[i, j];
            }
        return (maxVal, minVal);
    }

    static int DongTongMax(int[,] a)
    {
        int n = a.GetLength(0), m = a.GetLength(1);
        int dongMax = 0, tongMax = int.MinValue;
        for (int i = 0; i < n; i++)
        {
            int tong = 0;
            for (int j = 0; j < m; j++) tong += a[i, j];
            if (tong > tongMax)
            {
                tongMax = tong;
                dongMax = i;
            }
        }
        return dongMax;
    }

    static bool LaSoNguyenTo(int x)
    {
        if (x < 2) return false;
        for (int i = 2; i * i <= x; i++)
            if (x % i == 0) return false;
        return true;
    }

    static int TongKhongNguyenTo(int[,] a)
    {
        int tong = 0;
        int n = a.GetLength(0), m = a.GetLength(1);
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
                if (!LaSoNguyenTo(a[i, j])) tong += a[i, j];
        return tong;
    }

    static int[,] XoaDong(int[,] a, int k)
    {
        int n = a.GetLength(0), m = a.GetLength(1);
        if (k < 0 || k >= n) return a;
        int[,] b = new int[n - 1, m];
        int bi = 0;
        for (int i = 0; i < n; i++)
        {
            if (i == k) continue;
            for (int j = 0; j < m; j++)
                b[bi, j] = a[i, j];
            bi++;
        }
        return b;
    }

    static int[,] XoaCotMax(int[,] a)
    {
        int n = a.GetLength(0), m = a.GetLength(1);
        (int maxVal, _) = TimMaxMin(a);

        bool[] cotBiXoa = new bool[m];
        int soCotCon = m;

        for (int j = 0; j < m; j++)
            for (int i = 0; i < n; i++)
                if (a[i, j] == maxVal)
                {
                    if (!cotBiXoa[j]) soCotCon--;
                    cotBiXoa[j] = true;
                    break;
                }

        int[,] b = new int[n, soCotCon];
        for (int i = 0; i < n; i++)
        {
            int bj = 0;
            for (int j = 0; j < m; j++)
            {
                if (cotBiXoa[j]) continue;
                b[i, bj++] = a[i, j];
            }
        }
        return b;
    }

    static void Main(string[] args)
    {
        Console.Write("Nhap so dong n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Nhap so cot m: ");
        int m = int.Parse(Console.ReadLine());

        int[,] matr = TaoMaTran(n, m);
        Console.WriteLine("\nMa tran ban dau:");
        XuatMaTran(matr);

        var (maxVal, minVal) = TimMaxMin(matr);
        Console.WriteLine($"\nPhan tu lon nhat = {maxVal}, nho nhat = {minVal}");

        int dongMax = DongTongMax(matr);
        Console.WriteLine($"Dong co tong lon nhat: {dongMax}");

        Console.WriteLine($"Tong cac so khong phai la so nguyen to = {TongKhongNguyenTo(matr)}");

        Console.Write("\nNhap dong k can xoa: ");
        int k = int.Parse(Console.ReadLine());
        matr = XoaDong(matr, k);
        Console.WriteLine("Ma tran sau khi xoa dong:");
        XuatMaTran(matr);

        matr = XoaCotMax(matr);
        Console.WriteLine("\nMa tran sau khi xoa cot chua phan tu lon nhat:");
        XuatMaTran(matr);
    }
}
