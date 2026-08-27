using System;

class Program
{
    // Hàm kiểm tra số nguyên tố
    static bool IsPrime(int n)
    {
        if (n < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
                return false;
        }

        return true;
    }

    // Hàm kiểm tra số hoàn hảo
    static bool IsPerfectNumber(int n)
    {
        if (n <= 1)
            return false;

        int sum = 1;

        for (int i = 2; i <= n / 2; i++)
        {
            if (n % i == 0)
                sum += i;
        }

        return sum == n;
    }

    static void Main()
    {
        // Nhập N
        Console.Write("Nhap N = ");
        int N = int.Parse(Console.ReadLine());

        // Kiểm tra số hoàn hảo
        if (IsPerfectNumber(N))
            Console.WriteLine($"{N} la So hoan hao!");
        else
            Console.WriteLine($"{N} KHONG la So hoan hao.");

        // Kiểm tra số nguyên tố
        if (IsPrime(N))
            Console.WriteLine($"{N} la So nguyen to!");
        else
            Console.WriteLine($"{N} KHONG la So nguyen to.");

        // In N số Fibonacci đầu tiên
        Console.Write($"Day Fibonacci {N} so: ");

        int a = 0;
        int b = 1;

        for (int i = 0; i < N; i++)
        {
            Console.Write(a);

            if (i < N - 1)
                Console.Write(", ");

            int c = a + b;
            a = b;
            b = c;
        }

        Console.WriteLine();
    }
}