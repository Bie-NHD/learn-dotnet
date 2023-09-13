namespace ConsoleApp_01
{
    internal class BaiTap01
    {
        //        1. In ra chữ số hàng trăm, hàng chục, hàng đơn vị của một số có ba chữ số.Ví dụ khi
        //  nhập số 365 thì in ra: Chữ số hàng trăm: 3, hàng chục: 6, hàng đơn vị: 5
        public static void cau1()
        {
            int number;
            Console.WriteLine("Nhap so co 3 chu so: ");
            Int32.TryParse(Console.ReadLine(),out number);

            Console.WriteLine($"{number}: hang tram: {number/100}, hang chuc: {number%100/10}, hang don vi {number % 10}");
        }


        //        2. Nhập bán kính đường tròn r.Tính và xuất chu vi, diện tích đường tròn tương ứng
        //         (cv= 2 * π * r và dt = π * r2)
        public static void cau2()

        {

            Console.WriteLine("Nhap ban kinh: ");
            float r = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine(" Ban kinh r = {0} \n Chu vi P = {1} \n Dien tich S = {2}", r, 2 * r * Math.PI, Math.Pow(r, 2) * Math.PI);
        }
        //3. Nhập cạnh a.Tính và xuất chu vi, diện tích hình vuông(cv= 4 * a và dt = a2
        public static void cau3()
        {
            Console.WriteLine("Nhap canh hinh vuong: ");
            float a = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine(" Canh hinh vuong a = {0}\n Chu vi P = {1}\n Dien tich S = {2}", a, 4 * a, a * a);
        }
        public static void cau4()
        {
            Console.WriteLine("Nhap canh a: ");
            float a = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Nhap canh b: ");
            float b = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine(" Canh a = {0}\n Canh b = {3}\n Chu vi P = {1}\n Dien tich S = {2}", a, 2 * (a + b), a * b, b);

        }
        //5. Nhập cạnh a, b, c.Tính và xuất chu vi, diện tích hình tam giác(cv= a + b + c và
        //dt = sqrt(p(p − a)(p – b)(p − c)) với p = cv / 2)
        public static void cau5()
        {
            float a, b, c;
            Console.WriteLine("Nhap canh a: ");
            a = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Nhap canh b: ");
            b = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Nhap canh c: ");
            c = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine(" Canh a = {0}\n Canh b = {1}\n Canh c = {2} ", a, b, c);
            float q = (a + b + c) / 2;
            Console.WriteLine("Chu vi P = {0}\n Dien tich S = {1}", q * 2, Math.Sqrt(q * (q - a) * (q - b) * (q - c)));
        }
        //Nhập vào hai số nguyên dương a, b.Tính và xuất tổng, hiệu, tích, thương (lưu ý
        //phép chia với số nguyên).
        public static void cau6()
        {
            int a, b;
            Console.WriteLine("Nhap a = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap b = ");

            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a = {0}\nb = {1}", a, b);
            Console.WriteLine("a+b = {0}", a + b);
            Console.WriteLine("a-b = {0}", a - b);
            Console.WriteLine("a*b = {0}", a * b);
            Console.WriteLine("a/b = {0}", a / b);
        }
        //Viết chương trình nhập vào điểm ba môn Toán, Lý, Hóa của một học sinh.In ra
        //điểm trung bình của học sinh đó với hai số lẻ thập phân.
        public static void cau7()
        {
            float toan, ly, hoa;

            Console.WriteLine("Nhap diem  Toan: ");
            toan = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Nhap diem Ly: ");
            ly = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Nhap diem Hoa: ");
            hoa = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Toan: " + toan + "\nLy: " + ly + "\nHoa: " + hoa);
            Console.WriteLine("Diem trun binh: {0:f2}", (toan + ly + hoa) / 3);

        }
        //8. Viết chương trình nhập vào tên, năm sinh 1 người bất kỳ.Sau đó in lên màn hình
        //các kết quả sau: tên, năm sinh, tuổi hiện tại.Biết rằng ngày giờ hiện tại của máy
        //được lấy như sau:

        //DateTime thoiGianHienTai = DateTime.Now;
        //        int namHienTai = thoiGianHienTai.Year;
        public static void cau8()
        {
            DateTime curr = DateTime.Now;
            int birthYear = curr.Year;
            int age;
            string name = "";

            Console.WriteLine("Nhap ten: ");
            name = Console.ReadLine();

            while (true)
            {

                Console.WriteLine("Nhap nam sinh: ");
                birthYear = int.Parse(Console.ReadLine());

                age = curr.Year - birthYear;

                if (birthYear > curr.Year || age > 120)
                {
                    Console.WriteLine("Nam sinh khong hop le!");
                    continue;
                }

                break;

            }

            Console.WriteLine("Ten: {0}\nNam sinh: {1}\nTuoi: {2}", name, birthYear, curr.Year - birthYear);

        }
        //9. Viết chương trình nhập họ tên, chỉ số điện kế tháng trước, chỉ số điện kế tháng này
        //của 1 khách thuê điện kế.Sau đó in lên màn hình hoá đơn tiền điện có dạng sau:
        //----------------------------------------
        //Hoá đơn tiền điện
        //Khách hàng: < họ tên >
        //Chỉ số cũ: < chỉ số cũ >
        //Chỉ số mới: < chỉ số mới>
        //Tiêu thụ: < chỉ số mới - chỉ số cũ >
        //Tiền điện: < tiêu thụ * 452.45 >
        //Tiết kiệm điện là quốc sách
        public static void cau9()
        {
            string name;
            int oldValue, newValue, consume;

            Console.WriteLine("Nhap ten khach hang: ");
            name = Console.ReadLine();
            Console.WriteLine("Chỉ số cũ: ");
            oldValue = int.Parse(Console.ReadLine());
            Console.WriteLine("Chỉ số mới: ");
            newValue = int.Parse(Console.ReadLine());
            consume = newValue - oldValue;


            Console.WriteLine("Hoá đơn tiền điện");
            Console.WriteLine("Khách hàng: ");
            Console.WriteLine("Chỉ số cũ: "+oldValue);
            Console.WriteLine("Chỉ số mới: "+newValue);
            Console.WriteLine("Tiêu thụ: "+consume);
            Console.WriteLine("Tiền điện: "+consume*452.45);
            Console.WriteLine("Chỉ số mới: ");
        Console.WriteLine("Tiết kiệm điện là quốc sách");
        }
    }
}
