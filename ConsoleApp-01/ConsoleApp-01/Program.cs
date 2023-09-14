// See https://aka.ms/new-console-template for more information



using ConsoleApp_01;
using System.Text;

internal class Program
{
    static void Main(string[] args)
    {

        int page = 1;
        Console.OutputEncoding = UTF8Encoding.UTF8;
        //Console.ReadLine();
        int[] quantity = { 9, 15 };


        while (true)
        {
        Console.WriteLine("1- Bai 1.");
        Console.WriteLine("2- Bai 2.");
        Console.WriteLine("0- Exit");



        switch (Convert.ToInt32(Console.ReadLine()))
        {
            case 0:
                {
                    page--;
                    if (page == 0) return;

                    break;
                }
            case 1: chooseB1();  break;
            case 2: chooseB2(); break;

        }

        }



    }
    private static void printOptions(int quantity)
    {
        Console.WriteLine("Chon cau hoi: \n");


        for (int i = 1; i <= quantity; i++) Console.WriteLine("{0}. Cau {0}", i);
        Console.WriteLine("0. Thoat");

    }
    private static bool chooseB1()
    {
        printOptions(9);

        switch (Convert.ToInt32(Console.ReadLine()))
        {
            case 0:

                return false;



            case 1: BaiTap01.cau1(); break;
            case 2: BaiTap01.cau2(); break;
            case 3: BaiTap01.cau3(); break;
            case 4: BaiTap01.cau4(); break;
            case 5: BaiTap01.cau5(); break;
            case 6: BaiTap01.cau6(); break;
            case 7: BaiTap01.cau7(); break;
            case 8: BaiTap01.cau8(); break;
            case 9: BaiTap01.cau9(); break;

        }
        return false;

    }
    private static bool chooseB2()
    {
        printOptions(15);

        switch (Convert.ToInt32(Console.ReadLine()))
        {
            case 0: return false;

            case 1: BaiTap02.cau1(); break;
            case 2: BaiTap02.cau2(); break;
            case 3: BaiTap02.cau3(); break;
            case 4: BaiTap02.cau4(); break;
            case 5: BaiTap02.cau5(); break;
            case 6: BaiTap02.cau6(); break;
            case 7: BaiTap02.cau7(); break;
            case 8: BaiTap02.cau8(); break;
            case 9: BaiTap02.cau9(); break;
            case 10: BaiTap02.cau10(); break;
            case 11: BaiTap02.cau11(); break;
            case 12: BaiTap02.cau12(); break;
            case 13: BaiTap02.cau13(); break;
            case 14: BaiTap02.cau14(); break;
            case 15: BaiTap02.cau15(); break;
        }
        return false;
    }
}