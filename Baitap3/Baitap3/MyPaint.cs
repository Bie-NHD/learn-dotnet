﻿namespace Baitap3
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
        public static void paintIncreasingRightTriangle(int h, bool isFilled = true)

        {
            var arr = new char[h, h];
            for (int row = 0; row < h; row++)
            {
                for (int col = 0; col < h; col++)
                {
                    if (col == row || col == 0 || row == h-1)

                        arr[row, col] = '*';
                    else
                    if (isFilled && col <= row)
                        arr[row, col] = '*';

                    else arr[row, col] = ' ';
                }
            }

            paint(arr, h, h);

        }
        public static void paintDecreasingLeftTriangle(int h, bool isFilled = true)

        {
            var arr = new char[h, h];
            for (int row = 0; row < h; row++)
            {
                for (int col = 0; col < h; col++)
                {
                    if (row == col || row == 0 || col == h -1)

                        arr[row, col] = '*';
                    else
                    if (isFilled && row < col) arr[row, col] = '*';

                    else arr[row, col] = ' ';
                }
            }

            paint(arr, h, h);


        }
        public static void paintIncreasingLeftTriangle(int h, bool isFilled = true)
        {
            var arr = new char[h, h];
            for (int row = 0; row < h; row++)
            {
                for (int col = h - 1; col >= 0; col--)
                {
                    if (col == h - 1 - row || row == h -1 || col == h -1)
                        arr[row, col] = '*';
                    else
                    if (col>h-1-row && isFilled) arr[row, col] = '*';
                    else arr[row, col] = ' ';
                }
            }
            paint(arr, h, h);
        }
        public static void paintDecreasingRightTriangle(int h, bool isFilled = true)
        {
            var arr = new char[h, h];
            for (int row = 0; row < h; row++)
            {
                for (int col = h - 1; col >= 0; col--)
                {
                    if (col == h - 1 - row || col == 0 || row == 0)
                        arr[row, col] = '*';
                    else
                        if (isFilled && col <= h - 1 - row) arr[row, col] = '*';
                    else arr[row, col] = ' ';
                }
            }
            paint(arr, h, h);
        }
        public static void paintEquillateralTriangle(int h, bool isFilled = true)
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
        public static void paintParallelogram(int h, bool isFilled = true)
        {
            // [row,col]
            var arr = new char[h * 2 - 1, h];
            for (int col = 0; col < h; col++)
            {
                for (int row = 0; row < h * 2 - 1; row++)
                {
                    if ((col == 0 && row < h) || (col == h - 1 && row >= h) || row == col || row == col + h - 1) arr[row, col] = '*';
                    else
                    if (isFilled && (row > col && row < col + h - 1)) arr[row, col] = '*';
                    else arr[row, col] = ' ';

                }
            }
            MyPaint.paint(arr, h * 2 - 1, h);
        }
        public static void paintRibbon(int h, bool isFilled = true)
        {
            // [row,col]
            var arr = new char[h * 2 - 1, h * 2 - 1];
            for (int col = 0; col < h * 2 - 1; col++)
            {
                for (int row = 0; row < h * 2 - 1; row++)
                {
                    if (row == col || row == h - 1 || (col == 0 && row < h) || (col == h * 2 - 2 && row >= h)) arr[row, col] = '*';
                    else
                    if (isFilled&& ((col < row && col < h && row < h) || (col >= h && row >= h && col > row))) arr[row, col] = '*';
                    else arr[row, col] = ' ';

                }
            }
            MyPaint.paint(arr, h * 2 - 1, h * 2 - 1);
        }
        public static void paint(char[,] arr, int row, int col)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(arr[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
