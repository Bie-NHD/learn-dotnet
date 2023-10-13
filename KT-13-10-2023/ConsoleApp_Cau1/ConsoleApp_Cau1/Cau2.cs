using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Cau1
{
    internal class Cau2
    {
        public static void exec(string str = "Khoa He Thong Thong Tin")
        {
            var charTable = str.ToLower()
                .Where(char.IsLetterOrDigit)
                .GroupBy(c => c)
                .Select(c => new { Char = c.Key, Count = c.Count() })
                .OrderBy(c => c.Count);

            var max = charTable.Last();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Ký tự '{max.Char}' xuất hiện nhiều nhất với số lần xuất hiện là {max.Count}");
            Console.ResetColor();

        }
    }
}
