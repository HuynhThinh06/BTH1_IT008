using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Nhap ngay: ");
        int ngay = int.Parse(Console.ReadLine());
        Console.Write("Nhap thang: ");
        int thang = int.Parse(Console.ReadLine());
        Console.Write("Nhap nam: ");
        int nam = int.Parse(Console.ReadLine());

        if (nam < 1 || thang < 1 || thang > 12 || ngay < 1)
        {
            Console.WriteLine("Ngay thang nam khong hop le");
            return;
        }

        int maxNgay;

        if (thang == 4 || thang == 6 || thang == 9 || thang == 11)
            maxNgay = 30;
        else if (thang == 2)
        {
            if ((nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0))
                maxNgay = 29;
            else
                maxNgay = 28;
        }
        else
            maxNgay = 31;

        if (ngay > maxNgay)
            Console.WriteLine("Ngay thang nam khong hop le");
        else
            Console.WriteLine("Ngay thang nam hop le");
        Console.ReadLine();
    }
}
