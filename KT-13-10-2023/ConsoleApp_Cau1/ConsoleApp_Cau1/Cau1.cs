using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Cau1
{
    internal class Cau1
    {
        public static void exec(int h = 4)
        {
            
            int w = h * 2;

            char [,] arr = new char[h,w];

            // fill arr
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    if (j == 0 || j == w - 1 || j == h-1) { arr[i, j] = '*'; }
                    else
                    if ((i == 0 && j >= h )|| ( i == h - 1 && j <h)) { arr[i,j] = '*'; }
                    else
                    if (i == j || i == j - (h-1)) { arr[i, j] = '*'; }
                    else arr[i, j] = ' ';
                }
            }
            // print arr
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    Console.Write(arr[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
