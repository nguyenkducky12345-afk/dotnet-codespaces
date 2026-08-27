using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Nhập số thứ nhất a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Nhập số thứ hai b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Nhập phép toán (+, -, *, /, %): ");
            char op = char.Parse(Console.ReadLine());

            double result = op switch
            {
                '+' => a + b,
                '-' => a - b,
                '*' => a * b,
                '/' => b == 0
                    ? throw new DivideByZeroException()
                    : a / b,
                '%' => b == 0
                    ? throw new DivideByZeroException()
                    : a % b,
                _ => throw new InvalidOperationException("Phép toán không hợp lệ!")
            };

            Console.WriteLine($"Kết quả: {result:F2}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Lỗi: Không thể chia cho 0!");
        }
        catch (FormatException)
        {
            Console.WriteLine("Lỗi: Dữ liệu nhập vào không hợp lệ!");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Lỗi: {ex.Message}");
        }
    }
}