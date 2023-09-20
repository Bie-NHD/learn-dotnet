using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap3
{
    internal class MyPaint
    {
        public static void paintAll(int h = 1, bool isFilled = true)
        {

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

            Console.WriteLine();
            paintEquillateralTriangle(h);
        }
        private static void paintIncreasingRightTriangle(int h, bool isFilled = true)

        {
            var arr = new char[h, h];
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    if (j <= i)

                        arr[i, j] = '*';
                    else arr[i, j] = ' ';
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
            Console.WriteLine(arr.Length);
        }
        private static void paintDecreasingLeftTriangle(int h, bool isFilled = true)

        {
            var arr = new char[h, h];
            for (int row = 0; row < h; row++)
            {
                for (int col = 0; col < h; col++)
                {
                    if (row <= col)

                        arr[row, col] = '*';

                    else arr[row, col] = ' ';
                }
            }

            paint(arr, h, h);


        }
        private static void paintIncreasingLeftTriangle(int h, bool isFilled = true)
        {
            var arr = new char[h, h];
            for (int row = 0; row < h; row++)
            {
                for (int col = h - 1; col >= 0; col--)
                {
                    if (col >= h - 1 - row)
                        arr[row, col] = '*';
                    else arr[row, col] = ' ';
                }
            }
            paint(arr, h, h);
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
            paint(arr, h, h);
        }
        private static void paintEquillateralTriangle(int h, bool isFilled = true)
        {
            // [row,col]
            var arr = new char[h, h * 2 - 1];
            for (int col = 0; col < h * 2 - 1; col++)
            {
                for (int row = 0; row < h; row++)
                {
                    if (col == h - 1 - row || col == row + h - 1 || row == h - 1)
                        arr[row, col] = '*';

                    else
                    if (isFilled && col > h - 1 - row && col < row + h - 1)
                        arr[row, col] = '*';
                    else arr[row, col] = ' ';

                }
            }

            paint(arr, h, h * 2 - 1);
        }
        private static void paintParallelogram (int h, bool isFilled = true)
        {

        }
        private static void paint(char[,] arr, int col, int row)
        {
            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    Console.Write(arr[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
