using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap3
{
    internal class Baitap3
    {
        public static void C1_C5()
        {
            int n, x;

            while (true)
            {

                Console.WriteLine("Nhap  n:");
                if (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("n khong hop le.");
                    continue;
                }
                break;
            }
            Console.WriteLine("n: " + n);
            Console.WriteLine("C1: {0:f2}", (n == 0) ? " chu y: n = 0" : C1(n));
            Console.WriteLine("C2: {0:f2}", C2(n));
            Console.WriteLine("C3: {0:f2}", C3(n));


            while (true)
            {

                Console.WriteLine("Nhap  x:");
                if (!int.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine("n khong hop le.");
                    continue;
                }
                break;
            }
            Console.WriteLine("C4: {0:f2}", C4(x, n));
        }
        static double C2(int n)
        {
            if (n == 0) return 1;

            double result = 0;

            //result = Enumerable.Range(0, 2*n+1).Sum(x => 1.0 / (x+=2));

            for (int i = 0; i <= n * 2 + 1; i += 2)
            {
                result += 1.0 / i;
            }

            return result;
        }
        static double C3(int n)
        {
            return (n == 0) ? 0 : Enumerable.Range(1, n).Sum(i => 1.0 / SumContinousN(i));
        }

        public static double C4(int x, int n)
        {
            return (n == 0) ? 0 : Enumerable.Range(1, n).Sum(i => Math.Pow(x, i) / SumContinousN(i));
        }
        private static void C6()
        {
            int count = 0;


            string _input;

            Console.WriteLine("Nhap so: ");
            _input = Console.ReadLine();
        }
        public static void C8()
        {
            int width, height;
            //char[,] arr;
            string[] arr;

            height = 4;
            width = 7;


            //while (true)
            //{

            //    Console.WriteLine("Nhap chieu dai (width): ");
            //    if (!Int32.TryParse(Console.ReadLine(), out width) )
            //    {
            //        Console.WriteLine("So khong hop le.\nXin hay nhap lai.");
            //        continue;
            //    }
            //    break;
            //}
            //while (true)
            //{

            //    Console.WriteLine("Nhap chieu rong (height): ");
            //    if (!Int32.TryParse(Console.ReadLine(), out height))
            //    {
            //        Console.WriteLine("So khong hop le.\nXin hay nhap lai.");
            //        continue;
            //    }
            //    break;
            //}

            //arr = new char[height, width];
            arr = new string[height];

            for (int i = 0; i < height; i++)
            {
                arr[i] = new string('*', width);
            }

            Console.WriteLine("1.");

            foreach (string s in arr) { Console.WriteLine(s); }

            string mid = "*" + new string(' ', width - 2) + "*";

            for (int i = 0; i < height; i++)
            {
                if (i > 0 && i < height - 1) arr[i] = mid;
            }

            Console.WriteLine("2.");

            foreach (string s in arr) { Console.WriteLine(s); }
        }
        static int Sum(params int[] numbrs)
        {
            return numbrs.Sum(x => x);
        }
        static float Sum(params float[] numbrs)
        {
            return numbrs.Sum(x => x);
        }
        static int SumContinousN(int n)
        {
            return n * (n + 1) / 2;
        }
        static double C1(int n)
        {
            return (n == 0) ? 0 : Enumerable.Range(1, n).Sum(x => 1.0 / x);
        }
        private static bool isPrime(int h)
        {
            for (int i = 2; i < Math.Sqrt(h); i++)
            {
                if (h % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }

}
