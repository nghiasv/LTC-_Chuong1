using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
        Console.WriteLine("Bài 45: Hãy tính tích các chữ số của số nguyên dương n");
        int x232 = 1;
        Console.WriteLine("Nhập n: ");
        int n1232 = int.Parse(Console.ReadLine());
        int n232 = n1232;
        while (n232 > 0)
        {
            int i232 = n232 % 10;
            x232 *= i232;
            n232 = n232 / 10;
        }
        Console.WriteLine($"Tích các chữ số của {n1232} là: {x232}");
    }
}