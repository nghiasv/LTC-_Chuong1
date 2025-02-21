using System.ComponentModel.Design;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
        Console.WriteLine("Bài 56: Hãy kiểm tra số nguyên dương n có toàn chữ số lẻ hay không");
        Console.WriteLine("Nhập số nguyên dương n : ");
        int n1232 = int.Parse(Console.ReadLine());
        bool tf232 = true;
        int n232 = n1232;
        while (n232 > 0 )
        {
            int i232 = n232 % 10;
            if ( i232%2 == 0)
            {
                tf232 = false;
                break;
            }
            n232 /= 10;
        }
        if (!tf232)
        {
            Console.WriteLine($"Các số trong {n1232} không chứa toàn chữ số lẻ");
        }
        else
        {
            Console.WriteLine($"Các số trong {n1232} chứa toàn chữ số lẻ");
        }
    }
}