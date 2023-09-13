// See https://aka.ms/new-console-template for more information

using System.Text;

namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Nhập số trong khoảng [1..100]
            //while (true)
            //{
            //    Console.Write("Nhập số: ");
            //    int x = Convert.ToInt32(Console.ReadLine());

            //    if (x >= 1 && x <= 100)
            //    {
            //        Console.WriteLine("OK. " + x);
            //        break;
            //    }
            //    Console.WriteLine("Nhập sai.");
            //}

            // Tinhs tổng số lẻ 1..50, bỏ qua 13 và 27

            int tong = 0, count = 0;
            for (int i = 0; i < 50; i+=2)
            {
                tong += i; count++;
            }
            tong = tong - 13 - 27;
            Console.WriteLine("Odd count: " + count);
            Console.WriteLine("cách 1: " + tong);
            Console.WriteLine("Cach 2:" + (Math.Pow(50 / 2, 2) - 13 - 17));
            

        }
    }
}