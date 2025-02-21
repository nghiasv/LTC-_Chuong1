using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
        Console.WriteLine("Bài 67: Tính S(x, n) = x – x^2 + x^3 + … + (-1)^n+1 * x^n");
        Console.Write("Nhập giá trị x: ");
        double x232 = double.Parse(Console.ReadLine());
        Console.Write("Nhập số mũ n: ");
        int n232 = int.Parse(Console.ReadLine());
        double S232 = 0;
        for (int i232 = 1; i232 <= n232; i232++)
        {
            // Tính x232^i232
            double t232 = Math.Pow(x232, i232);
            int sign232 = (i232 % 2 == 1) ? 1 : -1;

            S232 += sign232 * t232;
        }

        Console.WriteLine($"S({x232}, {n232}) = {S232}");
    }
}