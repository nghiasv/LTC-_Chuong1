using System;
using System.Text;

internal class Bai2
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
        Console.WriteLine("Bài 12: Tính S(n) = x + x^2 + x^3 + … + x^n");

        Console.Write("Nhập n232: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Nhập x232: ");
        double x232 = double.Parse(Console.ReadLine());

        double sum232 = 0;
        for (int i232 = 1; i232 <= n; i232++)
        {
            sum232 += Math.Pow(x232, i232);
        }

        Console.WriteLine($"Tổng S(n232) = {sum232}");
    }
}
