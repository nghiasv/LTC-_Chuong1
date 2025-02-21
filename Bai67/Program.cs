using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
        Console.WriteLine("Bài 67: Tính S(x, n) = x – x^2 + x^3 + … + (-1)^n+1 * x^n");
    }
}