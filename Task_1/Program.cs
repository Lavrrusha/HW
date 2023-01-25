using System;

class Program
{
    static void Main(string[] args)
    {
        int N = GetNumberFromUser();
        PrintNumbers(N);
    }

    static int GetNumberFromUser()
    {
        int n;
        while (true)
        {
            Console.Write("Введите натуральное число: ");
            string input = Console.ReadLine()!;
            bool success = int.TryParse(input, out n);
            if (success && n > 0)
            {
                return n;
            }
            Console.WriteLine("Недопустимый ввод. Пожалуйста, введите положительное целое число.");
        }
    }

    static void PrintNumbers(int n)
    {
        if (n == 0)
        {
            return;
        }
        Console.WriteLine(n);
        PrintNumbers(n - 1);
    }
}