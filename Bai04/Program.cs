using System;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Nhap thang: ");
        int thang = int.Parse(Console.ReadLine());
        Console.Write("Nhap nam: ");
        int nam = int.Parse(Console.ReadLine());

        if (thang < 1 || thang > 12 || nam < 1)
        {
            Console.WriteLine("Thang hoac nam khong hop le");
            return;
        }

        int soNgay;
        switch (thang)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                soNgay = 31;
                break;
            case 2:
                if ((nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0))
                    soNgay = 29;
                else
                    soNgay = 28;
                break;
            default:
                soNgay = 30;
                break;
        }

        Console.WriteLine($"So ngay trong thang {thang}/{nam} la: " +soNgay);
    }
}