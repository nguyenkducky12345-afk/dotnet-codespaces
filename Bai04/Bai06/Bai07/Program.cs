using System;

class Program
{
    static void Main()
    {
        int choice;

        do
        {
            Console.Clear();

            Console.WriteLine("========== MENU ==========");
            Console.WriteLine("1. Chay Bai tap 1 (Calculator)");
            Console.WriteLine("2. Chay Bai tap 2 (Phuong trinh bac 2)");
            Console.WriteLine("3. Chay Bai tap 3 (So nguyen to & Fibonacci)");
            Console.WriteLine("0. Thoat chuong trinh");
            Console.WriteLine("==========================");
            Console.Write("Nhap lua chon: ");

            choice = int.Parse(Console.ReadLine());

            Console.Clear();

            switch (choice)
            {
                case 1:
                    BaiTap1();
                    break;

                case 2:
                    BaiTap2();
                    break;

                case 3:
                    BaiTap3();
                    break;

                case 0:
                    Console.WriteLine("Da thoat chuong trinh!");
                    break;

                default:
                    Console.WriteLine("Lua chon khong hop le!");
                    break;
            }

            // Nếu chưa chọn 0 thì dừng để xem kết quả
            if (choice != 0)
            {
                Console.WriteLine();
                Console.WriteLine("Nhan phim bat ky de quay lai Menu...");
                Console.ReadKey();
            }

        } while (choice != 0);
    }


    // =========================
    // BAI TAP 1 - CALCULATOR
    // =========================
    static void BaiTap1()
    {
        Console.WriteLine("===== BAI TAP 1: CALCULATOR =====");

        Console.Write("Nhap so a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Nhap so b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Nhap phep toan (+, -, *, /): ");
        char op = char.Parse(Console.ReadLine());

        switch (op)
        {
            case '+':
                Console.WriteLine($"Ket qua: {a + b}");
                break;

            case '-':
                Console.WriteLine($"Ket qua: {a - b}");
                break;

            case '*':
                Console.WriteLine($"Ket qua: {a * b}");
                break;

            case '/':
                if (b != 0)
                    Console.WriteLine($"Ket qua: {a / b}");
                else
                    Console.WriteLine("Khong the chia cho 0!");
                break;

            default:
                Console.WriteLine("Phep toan khong hop le!");
                break;
        }
    }


    // =========================
    // BAI TAP 2 - PHUONG TRINH BAC 2
    // =========================
    static void BaiTap2()
    {
        Console.WriteLine("===== BAI TAP 2: PHUONG TRINH BAC 2 =====");

        Console.Write("Nhap a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Nhap b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Nhap c: ");
        double c = double.Parse(Console.ReadLine());

        if (a == 0)
        {
            if (b == 0)
            {
                if (c == 0)
                    Console.WriteLine("Phuong trinh vo so nghiem.");
                else
                    Console.WriteLine("Phuong trinh vo nghiem.");
            }
            else
            {
                double x = -c / b;
                Console.WriteLine($"Phuong trinh co nghiem x = {x}");
            }
        }
        else
        {
            double delta = b * b - 4 * a * c;

            if (delta < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem.");
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"Phuong trinh co nghiem kep x = {x}");
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                Console.WriteLine($"x1 = {x1}");
                Console.WriteLine($"x2 = {x2}");
            }
        }
    }


    // =========================
    // BAI TAP 3 - SO NGUYEN TO & FIBONACCI
    // =========================
    static void BaiTap3()
    {
        Console.WriteLine("===== BAI TAP 3: SO NGUYEN TO & FIBONACCI =====");

        Console.Write("Nhap N = ");
        int N = int.Parse(Console.ReadLine());

        // Kiem tra so nguyen to
        if (IsPrime(N))
            Console.WriteLine($"{N} la So nguyen to!");
        else
            Console.WriteLine($"{N} KHONG la So nguyen to.");

        // Kiem tra so hoan hao
        if (IsPerfectNumber(N))
            Console.WriteLine($"{N} la So hoan hao!");
        else
            Console.WriteLine($"{N} KHONG la So hoan hao.");

        // In Fibonacci
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


    // Ham kiem tra so nguyen to
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


    // Ham kiem tra so hoan hao
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
}