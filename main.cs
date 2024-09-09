using System;

class Program
{
    static int Fibonacci(int a, int b, int n)
    {
        if (n == 0) return a;
        if (n == 1) return b;
        int[] fib = new int[n + 1];
        fib[0] = a;
        fib[1] = b;
        for (int i = 2; i <= n; i++)
        {
            fib[i] = fib[i - 1] + fib[i - 2];
        }
        return fib[n];
    }

    static void Main()
    {
        Random rand = new Random();
        int a = rand.Next(10);
        int b = rand.Next(10);

        int[] fibonacciArray = new int[10];
        int sum = 0;

        for (int i = 0; i < 10; i++)
        {
            fibonacciArray[i] = Fibonacci(a, b, i);
            Console.WriteLine(fibonacciArray[i]);
            sum += fibonacciArray[i];
        }

        int squareOfSum = sum * sum;

        Console.WriteLine($"Фиб1: {fibonacciArray[0]}, Фиб2: {fibonacciArray[1]}, Квадрат суммы: {squareOfSum}");
    }
}
