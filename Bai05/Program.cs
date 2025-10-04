using System;
internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhap ngay: ");
        int day = int.Parse(Console.ReadLine());

        Console.Write("Nhap thang: ");
        int month = int.Parse(Console.ReadLine());

        Console.Write("Nhap nam: ");
        int year = int.Parse(Console.ReadLine());

        try
        {
            DateTime date = new DateTime(year, month, day);
            string thu = "";

            switch (date.DayOfWeek)
            {
                case DayOfWeek.Sunday: thu = "Chu nhat"; break;
                case DayOfWeek.Monday: thu = "Thu hai"; break;
                case DayOfWeek.Tuesday: thu = "Thu ba"; break;
                case DayOfWeek.Wednesday: thu = "Thu tu"; break;
                case DayOfWeek.Thursday: thu = "Thu nam"; break;
                case DayOfWeek.Friday: thu = "Thu sau"; break;
                case DayOfWeek.Saturday: thu = "Thu bay"; break;
            }

            Console.WriteLine($"Ngay {day}/{month}/{year} la {thu}");
        }
        catch (Exception)
        {
            Console.WriteLine("Ngay thang nam khong hop le!");
        }
    }
}