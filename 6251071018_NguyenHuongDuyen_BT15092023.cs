// See https://aka.ms/new-console-template for more information

using System.Data;

internal class Program
{
    public static void Main(string[] args)
    {
        int h = 0;
        while (true)
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

        Console.WriteLine("\nIncreasing Right Triangle.");

        paintIncreasingRightTriangle(h);
        Console.WriteLine("\nDecreasing Left Triangle");

        paintDecreasingLeftTriangle(h);
        Console.WriteLine("\nIncreasing Left Triangle.");
        paintIncreasingLeftTriangle(h);
        Console.WriteLine("\nDecreasing Right Triangle.");
        paintDecreasingRightTriangle(h);
    }
    private static void paintIncreasingRightTriangle(int h,char drawSymbol = '*', char blankSymbol=' ')

    {
        var arr = new char[h, h];
        for (int i = 0; i < h; i++)
        {
            for (int j = 0; j < h; j++)
            {
                if (j <= i)
                
                    arr[i, j] = drawSymbol;
                else arr[i, j] = blankSymbol;
            }
        }

        for (int i = 0; i < h; i++)
        {
            for (int j = 0; j < h; j++)
            {
                Console.Write(arr[i, j]);
            }
            Console.WriteLine();
        }
    }
    private static void paintDecreasingLeftTriangle(int h, char drawSymbol = '*', char blankSymbol = ' ')

    {
        var arr = new char[h, h];
        for (int row = 0; row < h; row++)
        {
            for (int col = 0; col < h; col++)
            {
                if (row <= col)

                    arr[row, col] = drawSymbol;

                else arr[row, col] = blankSymbol;
            }
        }

        for (int row = 0; row < h; row++)
        {
            for (int col = 0; col < h; col++)
            {
                Console.Write(arr[row, col]);
            }
            Console.WriteLine();
        }

        
    }
    private static void paintIncreasingLeftTriangle(int h)
    {
        var arr = new char[h, h];
        for (int row=0; row < h; row++)
        {
            for (int col = h-1; col >= 0; col--)
            {
                if (col >= h -1 - row)
                    arr[row, col] = '*';
                else arr[row, col] = ' ';
            }
        }
        for (int i = 0; i < h; i++)
        {
            for (int j = 0; j < h; j++)
            {
                Console.Write(arr[i, j]);
            }
            Console.WriteLine();
        }
    }
    private static void paintDecreasingRightTriangle(int h)
    {
        var arr = new char[h, h];
        for (int row = 0; row < h; row++)
        {
            for (int col = h - 1; col >= 0; col--)
            {
                if (col <= h - 1 - row)
                    arr[row, col] = '*';
                else arr[row, col] = ' ';
            }
        }
        for (int i = 0; i < h; i++)
        {
            for (int j = 0; j < h; j++)
            {
                Console.Write(arr[i, j]);
            }
            Console.WriteLine();
        }
    }
}
