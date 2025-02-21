using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
        Console.WriteLine("Bài 23: Đếm số lượng “ước số” của số nguyên dương n");
        Console.Write("Nhập số nguyên dương n: ");
        int n232 = int.Parse(Console.ReadLine());
        int count232 = 0;
        for (int i232 = 1; i232 <= n232; i232++)
        {
            if (n232 % i232 == 0)
            {
                count232++;
            }
        }
        Console.WriteLine($"Số lượng ước số của {n232} là: {count232}");
    }
}