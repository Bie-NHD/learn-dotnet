using System.Globalization;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Xml;

namespace ConsoleApp_01
{
    internal class BaiTap02

    {
        //Cứ 3 thùng thì được thưởng 1 cái nón, số thùng còn dư
        //thì cứ 1 thùng được thưởng 2 cây viết, một thùng giá 350.000 đ
        public static void cau1()
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
        public static void cau2()
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
        public static void cau3()
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

            Console.WriteLine("Can nang: {0:1f}\nChieu cao: {1:1f}\nBMI: {2:1f} - {3}", w, h, bmi, message);

        }
        //        4. Tính chỉ số WHI(chỉ số vòng hông) một người dựa vào công thức:
        //WHI= Math.Round((Waist / Hip) * 100) / 100

        //Trong đó:
        //▪ Waist: kích thước eo;
        //▪ Hip: kích thước hông;
        //▪ Round: Là hàm làm tròn lấy từ lớp Math(thư viện chứa các hàm toán học cơ
        //bản).
        //Cho biết khả năng mắc bệnh tiểu đường của người này:

        //WHI Khả năng mắc bệnh
        //Nhỏ hơn 0.9 Nguy cơ tiểu đường thấp
        //Từ 0.9 trở lên Khả năng tiểu đường lớn hơn 50%
        public static void cau4()
        {
            float waist, hip;

            while (true)
            {
                Console.WriteLine("Nhap kich thuoc eo: ");
                if (!float.TryParse(Console.ReadLine(), out waist) || waist <= 0)
                {
                    Console.WriteLine("Nhap sai cu phap!\nHay nhap lai.");
                    continue;
                }
                break;
            }
            while (true)
            {
                Console.WriteLine("Nhap kich thuoc hong: ");
                if (!float.TryParse(Console.ReadLine(), out hip) || hip <= 0)
                {
                    Console.WriteLine("Nhap sai cu phap!\nHay nhap lai.");
                    continue;
                }
                break;
            }

            double _WHI = Math.Round((waist / hip) * 100 / 100);
            string message = (_WHI < 0.9) ? "thap" : "lon hon 50%";
            Console.WriteLine($"\nWHI: {_WHI}\nNguy co tieu duong {message}");
        }
        //        5. Nhập vào số giây t bất kỳ >=0. Tính và xuất ra dạng Giờ:Phút:Giây
        //Ví dụ: 
        //Nhập 3750 thì xuất ra 1:2:30 AM
        //Nhập 51100 thì xuất ra 2:11:40 PM
        //Hướng Dẫn: hour=(t/3600)%24; minute=(t%3600)/60; second=(t%3600)%60
        public static void cau5()
        {
            int t = 0;
            while (true)
            {

                Console.WriteLine("Nhap t: ");
                if (int.TryParse(Console.ReadLine(), out t))
                {
                    Console.WriteLine("Nhap sai cu phap!\nHay nhap lai.");
                    continue;
                }
                break;
            }

            int hour = (t / 3600) % 2;
            int minute = t % 3600 / 60;
            int second = t % 3600 % 60;
            string timeOfDay;

            switch (hour / 12 % 2)
            {
                case 0: timeOfDay = "AM"; break;
                default: timeOfDay = "PM"; break;
            }

            Console.WriteLine($"{t}: {hour}:{minute}:{second}:{timeOfDay}");
        }
        //6. Nhập vào tháng t(với 1<=t<=12). Cho biết t thuộc quý mấy trong năm.
        public static void cau6()
        {
            int t;

            while (true)
            {
                Console.WriteLine("Nhap thang t: ");

                if (!(Int32.TryParse(Console.ReadLine(), out t) && (t < 1 || t > 12)))
                {
                    Console.WriteLine("Nhap sai cu phap!\nHay nhap lai.");
                    continue;
                }
                break;
            }
            int q; //quarter
            switch (t % 3)
            {
                case 0: q = t / 3; break;
                default: q = t / 3 + 1; break;
            }
            Console.WriteLine($"Thang {t} thuoc Q{q}");
        }
        //7. Nhập vào một năm và cho biết năm đó có phải là năm nhuận hay không? (Năm
        //nhuận là năm chia hết cho 4 mà không chia hết cho 100, hoặc chia hết cho 400).
        public static void cau7()
        {
            int y; // year

            while (true)
            {
                Console.WriteLine("Nhap nam: ");

                if (!Int32.TryParse(Console.ReadLine(), out y) || y < 0 || y > DateTime.Now.Year)
                {
                    Console.WriteLine("Nhap sai cu phap!\nHay nhap lai.");
                    continue;
                }
                break;
            }

            bool isLeapYear = ((y % 4 == 0) && (y % 100 != 0)) || y % 400 == 0;
            Console.WriteLine($"Nam {y} la nam " + (isLeapYear ? "nhuan" : "khong nhuan"));
        }
        //8. Nhập vào tháng t(với 1<=t<=12). Cho biết tháng t có bao nhiêu ngày.Riêng tháng
        //2 thì phải kiểm tra năm nhuận (Năm nhuận là năm chia hết cho 4 mà không chia hết
        //cho 100, hoặc chia hết cho 400).
        public static void cau8()
        {

        }
        //9. Nhập vào một ngày(ngày, tháng, năm). Tìm ngày kế sau ngày vừa nhập
        //(ngày/tháng/năm).
        public static void cau9()
        {
            //DateTime userDateTime;
            //Console.WriteLine("Nhap ngay theo cu phap dd/MM/yyyy: ");



            //while (true)
            //{
            //    string strDateTime = Console.ReadLine();
            //    try { userDateTime = DateTime.ParseExact(strDateTime, "dd/MM/yyyy", null); }
            //    catch (ArgumentException)
            //    // https://learn.microsoft.com/en-us/dotnet/api/system.globalization.datetimeformatinfo?view=net-6.0
            //    {
            //        Console.WriteLine(strDateTime);
            //        Console.WriteLine("Nhap sai cu phap!\nXin hay nhap lai: ");
            //        continue;
            //    }



            //    break;
            //}

            //DateTime nextDate = userDateTime.AddDays(1);
            ////nextDate.AddDays(1);


            //Console.WriteLine($"Ngay tiep theo cua ngay {userDateTime} la ngay {nextDate}");

            Console.WriteLine("Work in progess --- ");
        }
        //10. Nhập vào một ngày(ngày, tháng, năm). Tìm ngày kế trước ngày vừa nhập
        //(ngày/tháng/năm).
        public static void cau10()
        {
            Console.WriteLine("Work in progess --- ");

        }
        //11. Nhập vào một ngày(ngày, tháng, năm). Cho biết ngày đó là ngày thứ bao nhiêu
        //trong tuần.
        public static void cau11()
        {
            Console.WriteLine("Work in progess --- ");

        }
        //12. Nhập vào số k
        //        12. Nhập vào số kWh tiêu thụ điện.Tính tiền điện phải trả biết rằng cách thức tính tiền
        //theo quy định như sau:
        //▪ 100 kWh định mức đầu tiên có đơn giá trung bình là 600 VNĐ/kWh
        //▪ Các kWh từ 101 đến 150 có đơn giá là 700 VNĐ/kWh
        //▪ Các kWh từ 151 đến 200 có đơn giá là 900 VNĐ/kWh
        //▪ Các kWh từ 201 trở đi có đơn giá là 1100 VNĐ/kWh    
        public static void cau12()
        {
            int value;
            int totalFee = 0;
            while (true)
            {
                Console.WriteLine("Nhap so kWh: ");
                if (!Int32.TryParse(Console.ReadLine(), out value))
                {
                    Console.WriteLine("Nhap sai cu phap. Xin hay nhap lai: ");
                    continue;
                }
                break;
            }

            Console.WriteLine("So kWh da dung: " + value);

            if (value > 200)
            {
                int temp = value - 200;
                totalFee += temp * 1100;
                value -= temp;
            }
            if (value > 150)
            {
                int temp = value - 150;
                totalFee += temp * 900;
                value -= temp;
            }
            if (value > 100)
            {
                int temp = value - 100;
                totalFee += temp * 700;
                value -= temp;
            }

            totalFee += value * 600;

            Console.WriteLine("Tong tien phai tra: " + totalFee + "VND");



        }
        //        13. Viết chương trình nhập họ tên, số ngày làm việc và số giờ làm việc ngoài giờ trong
        //tháng của một nhân viên.Sau đó in lên màn hình phiếu báo lương chi tiết có dạng
        //như bên dưới.Biết rằng ngày làm việc 8 tiếng.Công ty trả 70,000 đồng/1 giờ làm
        //việc.Công ty phải trả thêm 30% cho mỗi giờ làm việc ngoài giờ của nhân viên. 
        //Nếu nhân viên đi làm ít hơn 20 ngày trong tháng thì sẽ bị ghi "Kỹ luật" trong phần
        //ghi chú:
        //----------------------------------------
        //Phiếu báo lương chi tiết
        //Nhân viên: < họ tên >
        //Ngày công: < số ngày làm việc >
        //Làm việc ngoài giờ: < số giờ làm việc ngoài giờ >
        //Lương: < Số tiền >
        //Ghi chú: < Để trống hoặc "Kỹ luật">
        //------------------------------------------
        public static void cau13()
        {

        }
        //        14. Viết chương trình giả 1 máy tính tay với các phép toán đơn giản như +,-,*,/ và lấy
        //căn bậc 2.
        //Gợi ý: Nhập phép toán(toán tử) và 2 số(toán hạng). Lưu ý nếu lấy căn bậc 2 thì chỉ
        //nhập 1 toán hạng.
        public static void cau14()
        {
            Console.WriteLine("Work in progess --- ");

        }
        //15. Hãy viết chương trình đọc vào một số nguyên.
        //a.Tính và in ra cho biết số nguyên đó có bao nhiêu chữ số.
        //Ví dụ:
        //Hay nhap 1 so nguyen: 1462
        //So nay co: 4 chu so
        //b.Tính và in ra tổng các chữ số của số nguyên này.
        //Ví dụ:
        //Hay nhap 1 so nguyen: 2872
        //Tong cac chu so cua 1852 la: 2+8+7+2 = 19
        //c.Tính và in ra số nguyên có các chữ số có thứ tự ngược với các chữ số của số
        //ban đầu.
        //d.Một số nguyên dương gọi là đối xứng nếu đọc từ trái qua hay từ phải lại đều
        //giống nhau.Ví dụ các số sau đây là đối xứng: 12321, 9999, 55355,… Hãy
        //viết chương trình đọc vào một số nguyên dương và in ra thông báo cho biết số
        //này có đối xứng không. (đối xứng nếu số đó và số đảo ngược của nó bằng
        //nhau)
        public static void cau15()
        {

            int number;

            Console.ReadLine();
            while (true)
            {

                Console.WriteLine("Nhap so: ");


                if (!Int32.TryParse(Console.ReadLine().Trim(), out number))
                {
                    Console.WriteLine("So khong hop le!");
                    continue;
                }

                break;
            }

            string strNum = number.ToString();
            int strLen = strNum.Length;

            // a
            Console.WriteLine($"{number} co {strLen} chu so. ");
            // b
            int tempResult = number, sum = 0;
            while (tempResult != 0)
            {
                sum += tempResult % 10;
                tempResult /= 10;
            }
            Console.WriteLine("Tong cac chu so: {0}", sum);
            // c
            Console.WriteLine("Dao nguoc chuoi so: " + reverseNumString(strNum));
            // d

            bool checkAssym;
            int i = strLen / 2;

            switch (strLen % 2)
            {
                case 0:
                    {
                        checkAssym = strNum[i] == strNum[i + 1];
                        break;
                    }
                default:
                    {
                        checkAssym = strNum[i] == strNum[i + 2];
                        break;
                    }
            }

            string message = checkAssym ? "doi xung" : "khong doi xung";

            Console.WriteLine("So da nhap " + message);

        }
        private static string reverseNumString(string str)
        // tutorial:  https://stackoverflow.com/questions/228038/best-way-to-reverse-a-string/56937817#56937817
        {

            bool check = str[str.Length - 1] == '0';
            // Reverse str
            str = string.Create<string>(str.Length, str, (chars, state) =>
            {
                state.AsSpan().CopyTo(chars);
                chars.Reverse();
            });
            return (check) ? str.Substring(1, str.Length - 1) : str;

        }

    }
}

