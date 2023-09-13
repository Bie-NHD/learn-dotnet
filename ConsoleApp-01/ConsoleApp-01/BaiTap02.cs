using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_01
{
    internal class BaiTap02

    {
        //Cứ 3 thùng thì được thưởng 1 cái nón, số thùng còn dư
        //thì cứ 1 thùng được thưởng 2 cây viết, một thùng giá 350.000 đ
        public static void bai01()
        {
            const int DONGIA = 350000;
            Console.WriteLine("Nhap so thung son:");


            string sTam = Console.ReadLine();
            int iSoThungSon = Convert.ToInt32(sTam);
            int iSoNonDuocTang = iSoThungSon / 3;
            int iSoThungSonTangViet = iSoThungSon % 3; // sai ve logic
            int iSoVietDuocTang = iSoThungSonTangViet * 2;
            int iTienTra = iSoThungSon * DONGIA;
            Console.WriteLine("So tien: 0", iTienTra);
            Console.WriteLine("So non duoc tang: {0}", iSoNonDuocTang);
            Console.Out.WriteLine("So viet duoc tang: {0}", iSoVietDuocTang);
        }
        public static void bai02()
        {
            string strTenHang;
            Console.Write("Nhap ten hang: ");
            strTenHang = Console.ReadLine();
            Console.Write("Nhap so luong hang: ");
            string strTam;
            strTam = Console.ReadLine();
            int iSoLuong = Convert.ToInt32(strTam);
            Console.Write("Nhap vao don gia: ");
            strTam = Console.ReadLine();
            int iDonGia = Convert.ToInt32(strTam);
            int iThanhTien = iSoLuong * iDonGia;
            int iThueVAT = iThanhTien * 10 % 100;
            int iThucTra = iThanhTien + iThueVAT;
            Console.WriteLine("---------------------------");
            Console.WriteLine("Ten hang:{0},strTenHang");
            Console.WriteLine("So luong hang:{0}, iSoLuong");
            Console.WriteLine("Don gia:{0}, iDonGia");
            Console.WriteLine("Thanh Tien:{0}", iThanhTien);
            Console.WriteLine("Thue VAT:{0}", iThueVAT);
            Console.WriteLine("Thuc Tra:{0}", iThucTra);
            Console.WriteLine("--------------------------");
            Console.ReadLine();
        }

        //Viết chương trình tính chỉ số BMI của một người khi biết chiều cao và cân nặng.
        //Biết rằng: BMI = Weight / (Height* Height)
        static void bai03()
        {
            float w, h, bmi; // weight. height
            string message;

            Console.WriteLine("Nhap can nang: ");
            w = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Nhap chieu cao: ");
            h = Convert.ToSingle(Console.ReadLine());

            bmi = w / (h * h);

            if (bmi >= 30) message = "Beo phi";
            if (bmi >= 25) message = "Map";
            if (bmi >= 18.5)
                message = "Binh thuong";
            else message = "Gay";

            Console.WriteLine("Can nang: {0:1f}\nChieu cao: {1:1f}\nBMI: {2:1f} - {3}",w,h,bmi,message);

        }
    }
}
