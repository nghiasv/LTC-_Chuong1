using System;
using System.Text;

internal class Bai2
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
        Console.WriteLine("Bài 12: Tính S(n) = x + x^2 + x^3 + … + x^n");

        Console.Write("Nhập n: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Nhập x: ");
        double x = double.Parse(Console.ReadLine());

        double sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += Math.Pow(x, i);
        }

        Console.WriteLine($"Tổng S(n) = {sum}");
    }
}
