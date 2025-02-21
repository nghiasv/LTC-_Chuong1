using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
        Console.WriteLine("Bài 100: Viết chương trình giải phương trình bậc 2");
        // Nhập hệ số a, b, c
        Console.Write("Nhập a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Nhập b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Nhập c: ");
        double c = double.Parse(Console.ReadLine());
        // Nếu a = 0 thì không phải là phương trình bậc 2
        if (a == 0)
        {
            // Nếu a = 0 và b = 0
            if (b == 0)
            {
                if (c == 0)
                    Console.WriteLine("Phương trình có vô số nghiệm.");
                else
                    Console.WriteLine("Phương trình vô nghiệm.");
            }
            else
            {
                // Giải phương trình bậc nhất: bx + c = 0
                double x = -c / b;
                Console.WriteLine($"Phương trình có nghiệm: x = {x}");
            }
        }
        else
        {
            // Tính delta
            double delta = b * b - 4 * a * c;

            if (delta < 0)
            {
                Console.WriteLine("Phương trình vô nghiệm.");
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"Phương trình có nghiệm kép: x1 = x2 = {x}");
            }
            else
            {
                double sqrtDelta = Math.Sqrt(delta);
                double x1 = (-b + sqrtDelta) / (2 * a);
                double x2 = (-b - sqrtDelta) / (2 * a);
                Console.WriteLine($"Phương trình có 2 nghiệm phân biệt: x1 = {x1} và x2 = {x2}");
            }
        }
    }
}