using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Bài 78: Liệt kê tất cả các ước số của số nguyên dương n");
        Console.Write("Nhập số nguyên dương n: ");
        int n232 = int.Parse(Console.ReadLine());

        Console.WriteLine($"Các ước số của {n232} là:");

        // Duyệt từ 1 đến n để kiểm tra từng số có phải là ước số của n không
        for (int i232 = 1; i232 <= n232; i232++)
        {
            if (n232 % i232 == 0)
            {
                Console.WriteLine(i232);
            }
        }
    }
}