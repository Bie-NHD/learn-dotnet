// See https://aka.ms/new-console-template for more information

using System.Text;

namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;


            while (true)
            {
                Console.Write("Nhập số: ");
                int x = Convert.ToInt32(Console.ReadLine());

                if (x >= 1 && x <= 100)
                {
                    Console.WriteLine("OK. " + x);
                    break;
                }
                Console.WriteLine("Nhập sai.");
            }

            

        }
    }
}