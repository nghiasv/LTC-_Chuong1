using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
        Console.WriteLine("Bài 34: Tính S(n) = CanBac2(n+CanBac2(n – 1 + CanBac2( n – 2 + … + CanBac2(2 + CanBac2(1)  có n dấu căn");
        Console.WriteLine("Nhập n: ");
        int n232 = int.Parse(Console.ReadLine());
        double sum232 = TongS(n232);
        Console.WriteLine($"S({n232}) = {sum232}");
    }
    static double TongS(int n232)
    {
        if (n232 == 1)
            return Math.Sqrt(1);
        else
            return Math.Sqrt(n232 + TongS(n232 - 1));
    }
}