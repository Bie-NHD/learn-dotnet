// See https://aka.ms/new-console-template for more information



using ConsoleApp_01;

internal class Program
{
    static void Main(string[] args)
    {
        Console.ReadLine();
        Console.WriteLine("Chon cau hoi: \n");
        Console.WriteLine("2. Cau 2");
        Console.WriteLine("3. Cau 3");
        Console.WriteLine("4. Cau 4");
        Console.WriteLine("5. Cau 5");
        Console.WriteLine("6. Cau 6");
        Console.WriteLine("7. Cau 7");
        Console.WriteLine("8. Cau 8");


        Console.WriteLine("0. Thoat");
        switch (   
        Convert.ToInt32(Console.ReadLine())
            )
        {
            case 2:
                
                BaiTap01.cau2();               break;
                
            case 3: BaiTap01.cau3(); break;
            case 4: BaiTap01.cau4(); break;
            case 5: BaiTap01.cau5(); break;
            case 6: BaiTap01.cau6(); break;
            case 7: BaiTap01.cau7(); break;
            case 8: BaiTap01.cau8(); break;
            
        }
            


    }
}