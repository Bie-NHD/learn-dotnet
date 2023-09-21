using System.Text.RegularExpressions;

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
            Console.WriteLine("C5: {0:f2}", (n == 0) ? Math.Sqrt(0) : C5(n));



        }
        static double C1(int n)
        {
            return (n == 0) ? 0 : Enumerable.Range(1, n).Sum(x => 1.0 / x);
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

        static double C4(int x, int n)
        {
            return (n == 0) ? 0 : Enumerable.Range(1, n).Sum(i => Math.Pow(x, i) / SumContinousN(i));
        }
        static double C5(int n)
        {
            double result = 0;

            for (int i = n; i > 0; i--)
            {
                result = Math.Sqrt(i + result);
            }

            return result;
        }
        public static void C6()
        {
            int count = 0;


            string _input;

            while (true)
            {
                Console.WriteLine("Nhap so: ");
                _input = Console.ReadLine().Trim();

                if (!Regex.IsMatch(_input, @"/0-9/gm"))
                {
                    Console.WriteLine("So khong hop le.\nXin hay nhap lai.");
                    continue;
                }
                break;
            }

            foreach (var c in _input)
            {
                switch (int.Parse(c.ToString()))
                {
                    case 2: { count++; break; }
                    case 3: { count++; break; }
                    case 5: { count++; break; }
                    case 7: { count++; break; }
                    default: { continue; }

                }
            }
            Console.WriteLine("{0} co {1} chu so nguyen to.", _input, count);
        }
        public static void C7(int n = 1)
        {
            while (true && n == 1)
            {

                Console.WriteLine("Nhap  n:");
                if (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("n khong hop le.");
                    continue;
                }
                break;
            }

            // Initialize sum of prime factors
            int sum = 0;
            List<int> listOfDivisors = new List<int>();

            // Note that this loop runs till
            // square root of n
            for (int i = 1; i <= (Math.Sqrt(n)); i++)
            {
                if (n % i == 0 && isPrime(i))
                {

                    // If divisors are equal,
                    // take only one of them
                    if (n / i == i)
                    {
                        sum = sum + i;
                        listOfDivisors.Add(i);
                    }
                    else // Otherwise take both
                    {
                        sum = sum + i;
                        listOfDivisors.Add(i);

                        int temp = n / i;
                        if (isPrime(temp))
                        {
                            sum = sum + temp;

                            listOfDivisors.Add(temp);

                        }
                    }
                }
            }

            string var = sum < n ? "YES" : "NO";
            Console.WriteLine("Is Deficient: " + var);

            listOfDivisors.Sort();
            Console.WriteLine("Cac uoc so: ");
            listOfDivisors.ForEach(x => Console.Write(x + ","));
            Console.WriteLine();
            Console.WriteLine("Tong: " + sum);
        }
        public static void C8()
        {
            int width, height;
            string[] arr;

            height = 4;
            width = 7;


            while (true)
            {

                Console.WriteLine("Nhap chieu dai (width): ");
                if (!Int32.TryParse(Console.ReadLine(), out width))
                {
                    Console.WriteLine("So khong hop le.\nXin hay nhap lai.");
                    continue;
                }
                break;
            }
            while (true)
            {

                Console.WriteLine("Nhap chieu rong (height): ");
                if (!Int32.TryParse(Console.ReadLine(), out height))
                {
                    Console.WriteLine("So khong hop le.\nXin hay nhap lai.");
                    continue;
                }
                break;
            }

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
        public static void C9(int h = 1)
        {


            while (true && h == 1)
            {
                Console.WriteLine("Nhap chieu cao h:");
                if (!int.TryParse(Console.ReadLine(), out h)
                    )
                {
                    Console.WriteLine("Nhap sai cu phap! (h la so nguyen >0).\nHay nhap lai.\n");
                    continue;
                }
                break;
            }

            Console.WriteLine("Cac hinh ve voi h = " + h);
            //
            Console.WriteLine("\nIncreasing Right Triangle.\n");
            MyPaint.paintIncreasingRightTriangle(h);
            Console.WriteLine();
            MyPaint.paintIncreasingRightTriangle(h, false);
            //
            Console.WriteLine("\nDecreasing Left Triangle\n");
            MyPaint.paintDecreasingLeftTriangle(h);
            Console.WriteLine();
            MyPaint.paintDecreasingLeftTriangle(h, false);
            //
            Console.WriteLine("\nIncreasing Left Triangle.\n");
            MyPaint.paintIncreasingLeftTriangle(h);
            Console.WriteLine();
            MyPaint.paintIncreasingLeftTriangle(h, false);
            //
            Console.WriteLine("\nDecreasing Right Triangle.\n");
            MyPaint.paintDecreasingRightTriangle(h);
            Console.WriteLine();
            MyPaint.paintDecreasingRightTriangle(h, false);
            //
            Console.WriteLine("\nEquillateral Triangle: ");
            MyPaint.paintEquillateralTriangle(h);
            Console.WriteLine();
            MyPaint.paintEquillateralTriangle(h, false);
            // 
            Console.WriteLine("\nParallelogram: \n");
            MyPaint.paintParallelogram(h);
            Console.WriteLine();
            MyPaint.paintParallelogram(h, false);
            //
            MyPaint.paintRibbon(h);
            Console.WriteLine();
            MyPaint.paintRibbon(h, false);
        }
        public static void C10()
        {

            int count = 0;
            var rand = new Random();
            int question = rand.Next(1, 101);
            int answer;

            while (true && count != 7)
            {


                Console.WriteLine("Hay nhap so cua ban trong khoang [1..100]: ");
                if (!int.TryParse(Console.ReadLine(), out answer) || answer < 1 || answer > 100)
                {
                    Console.WriteLine("Nhap sai cu phap! (h la so nguyen >0).\nHay nhap lai.\n");
                    continue;
                }

                if (question == answer)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Haha ban tai that.");
                    Console.ResetColor();
                    break;
                }
                else
                {
                    ++count;

                    Console.WriteLine("So cua ban {0} hon so may!", (answer - question < 0) ? "nho" : "lon");

                    continue;
                }

            }

            if (count == 7)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Ban da thua!");
                Console.ResetColor();
                Console.WriteLine("So cua may la: " + question);
            }
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
