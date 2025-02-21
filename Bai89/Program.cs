using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
        Console.WriteLine("Bài 89: Viết chương trình tính tổng các giá trị lẻ nguyên dương nhỏ hơn N");
        Console.WriteLine("Nhập N :");
        int n232 = int.Parse(Console.ReadLine());
        int x232 = 0;
        for (int i232 = 1; i232 < n232; i232++)
        {
            if (i232 % 2 == 1)
            {
                x232 += i232;
            }
        }

        Console.WriteLine($"Tổng các giá trị lẻ nguyên dương nhỏ hơn {n232} là: {x232}");
    }
}