using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap3
{
    internal class Baitap3
    {
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
