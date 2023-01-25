using System;

class Program
{
    static void Main(string[] args)
    {
        int M = GetNumberFromUser("M");
        int N = GetNumberFromUser("N");
        int sum = SumNumbers(M, N);
        Console.WriteLine("Сумма натуральных чисел в промежутке от {0} до {1} равна {2}", M, N, sum);
    }

    static int GetNumberFromUser(string name)
    {
        int n;
        while (true)
        {
            Console.Write("Введите {0}: ", name);
            string input = Console.ReadLine()!;
            bool success = int.TryParse(input, out n);
            if (success && n > 0)
            {
                return n;
            }
            Console.WriteLine("Недопустимый ввод. Пожалуйста, введите положительное целое число.");
        }
    }

    static int SumNumbers(int m, int n)
    {
        if (m > n)
        {
            return 0;
        }
        return m + SumNumbers(m + 1, n);
    }
}