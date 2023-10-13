// See https://aka.ms/new-console-template for more information
using ConsoleApp_Cau1;
using System.Text;

class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;


        Cau_2();
    }

    private static void Cau_1()
    {
        int h;
        while (true)
        {

            Console.WriteLine("Nhập chiều cao h:");
            if (!int.TryParse(Console.ReadLine(), out h))
            {
                Console.WriteLine("Số h không hợp lệ.\nXin hãy nhập lại.");
                continue;
            }
            else break;
        }
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Hình có chiều cao h = {h} như sau:");
        Console.ResetColor();
        Cau1.exec(h);

    }

    private static void Cau_2()
    {
        Console.WriteLine(new string('-', 10));
        string str;

        while (true)
        {
            Console.WriteLine("Nhập chuỗi ký tự: ");

             

            str = Console.ReadLine();

            if (str == null || str == "")
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("Chuỗi ký tự rỗng hoặc trống.\nXin hãy nhập lại.");
                Console.ResetColor();
                continue;
            }
            else break;

        }
        Cau2.exec(str);
    }
}
