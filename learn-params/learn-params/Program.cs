// See https://aka.ms/new-console-template for more information


using System.Reflection.Metadata.Ecma335;

internal class Program
{
    static void Main()
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
        Console.WriteLine("C2: {0:f2}", C3(n));


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
}