// See https://aka.ms/new-console-template for more information


using Baitap3;
using System.Reflection.Metadata.Ecma335;

internal class Program
{
    public static void Main()
    {

        int var = 0;

        do
        {
            print();

            if (!int.TryParse(Console.ReadLine(), out var) || var < 1 || var > 10)
            {
                Console.WriteLine("So khong hop le.\nXin hay nhap lai.");
                continue;
            }


            switch (var)
            {
                case 1:
                    Baitap3.Baitap3.C1_C5();
                    break;
                case 6: Baitap3.Baitap3.C6(); break;
                case 7: Baitap3.Baitap3.C7(); break;
                case 8: Baitap3.Baitap3.C8(); break;
                case 9: Baitap3.Baitap3.C9(); break;
                case 10: Baitap3.Baitap3.C10(); break;
                default: continue;
            }


        }
        while (true && var != 0);

    }


    static void print()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nChon cau de hien thi.");

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("{0}. Bai {1}", i, (i == 1) ? "1..5" : i);
            if (i == 1) i = 5;
        }
        Console.WriteLine();
        Console.WriteLine("0 de thoat.");
        Console.ResetColor();
    }


}
