// See https://aka.ms/new-console-template for more information

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nhap n:");

        try
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("n la "+n);

            if (n < 18) throw new InvalidAgeException("Ban chua du tuoi!");
        }
        catch (FormatException )
        {
            Console.WriteLine("So sai.");
        }
        catch (InvalidAgeException e)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(e.Message);
            Console.ResetColor();
        }
    }
}

class InvalidAgeException : ApplicationException
{
    public InvalidAgeException(string message) : base(message)
    {

    }
}
