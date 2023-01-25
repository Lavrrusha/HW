using System;

class Program
{
    static void Main(string[] args)
    {
        int m = GetNumberFromUser("m");
        int n = GetNumberFromUser("n");
        int ackermann = A(m, n);
        Console.WriteLine("Результат функции Аккермана для m = {0} и n = {1} равен {2}", m, n, ackermann);
    }

    static int GetNumberFromUser(string name)
    {
        int n;
        while (true)
        {
            Console.Write("Введите {0}: ", name);
            string input = Console.ReadLine()!;
            bool success = int.TryParse(input, out n);
            if (success && n >= 0)
            {
                return n;
            }
            Console.WriteLine("Недопустимый ввод. Пожалуйста, введите неотрицательное целое число.");
        }
    }

    static int A(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        if (n == 0)
        {
            return A(m - 1, 1);
        }
        return A(m - 1, A(m, n - 1));
    }
}