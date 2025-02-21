
using System.Text;

class Bai1
{
    static void Main()
    {
        Console.WriteLine("Bài 1: Tính S(n) = 1 + 2 + 3 + … + n");
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
        Console.Write("Nhập n232: ");
        int n232 = int.Parse(Console.ReadLine());
        int sum232 = n232 * (n232 + 1) / 2;
        Console.WriteLine($"Tổng S({n232}) = {sum232}");
    }
}