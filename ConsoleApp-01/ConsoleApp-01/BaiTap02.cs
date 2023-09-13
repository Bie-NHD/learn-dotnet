using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_01
{
    internal class BaiTap02

    {
        public static void bai01()
        {
            const int DONGIA = 350000;
            Console.WriteLine("Nhap so thung son:");
           

            string sTam = Console.ReadLine(); 
            int iSoThungSon = Convert.ToInt32(sTam);
            int iSoNonDuocTang = iSoThungSon / 3;
            int iSoThungSonTangViet = iSoThungSon % 3;
            int iSoVietDuocTang = iSoThungSonTangViet * 2;
            int iTienTra = iSoThungSon * DONGIA;
            Console.WriteLine("So tien: 0", iTienTra);
            Console.WriteLine("So non duoc tang: {0}", iSoNonDuocTang);
            Console.Out.WriteLine("So viet duoc tang: {0}", iSoVietDuocTang);
        }
    }
}
