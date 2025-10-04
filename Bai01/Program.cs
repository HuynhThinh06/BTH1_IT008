using System;

internal class Program
{
    public static bool Check(int num)
    {
        if (num <= 1) return false;
        if (num == 2) return true;
        for (int i = 2; i * i <= num; i++)
            if (num % i == 0) return false;
        return true;
    }

    public static bool LaSoCP(int num)
    {
        int tmp = (int)Math.Sqrt(num);
        return tmp * tmp == num;
    }

    public static int TongSoLe(int[] arr)
    {
        int sum = 0;
        foreach (int x in arr)
            if (x % 2 != 0) sum += x;
        return sum;
    }

    public static int DemSoNguyenTo(int[] arr)
    {
        int count = 0;
        foreach (int x in arr)
            if (Check(x)) count++;
        return count;
    }

    public static int SoChinhPhuongNhoNhat(int[] arr)
    {
        int min = int.MaxValue;
        foreach (int x in arr)
        {
            if (LaSoCP(x) && x < min)
                min = x;
        }
        return (min == int.MaxValue) ? -1 : min;
    }

    private static void Main(string[] args)
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());
        Random rnd = new Random();
        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
            arr[i] = rnd.Next(0, 1000);

        for (int i=0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }    

        int sum = TongSoLe(arr);
        int count = DemSoNguyenTo(arr);
        int minCP = SoChinhPhuongNhoNhat(arr);

        Console.WriteLine("\nSUM = " + sum);
        Console.WriteLine("COUNT = " + count);
        Console.WriteLine("So chinh phuong nho nhat = " + minCP);
        Console.ReadLine();
    }
}
