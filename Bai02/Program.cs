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
    private static void Main(string[] args)
    {
        Console.Write("Nhap so n: ");
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 0; i < n; i++)
            if (Check(i))
                sum +=i;
        Console.WriteLine("Tong cac so nguyen to be hon n " + sum);
    }
}