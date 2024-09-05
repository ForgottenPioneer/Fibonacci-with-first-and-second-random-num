using System;

class Program
{
    static int Fibonacci(int n)
    {
        if (n <= 1) return n;
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    static void Main()
    {
        int[] fibbonacci_array = new int[2];
        int fib;
        Random rand = new Random();


        int sum = 0;
        for (int i = 0; i < 10; i++)
{
        if (i < 2){
           fib = Fibonacci(rand.Next(10));
           fibbonacci_array[i] = fib;
        }
        else{
        fib = Fibonacci(i);
        }
        Console.WriteLine(fib);
        sum += Fibonacci(i);
}

        int squareOfSum = sum * sum;

        Console.WriteLine($"Фиб1: {fibbonacci_array[0]}, Фиб2: {fibbonacci_array[1]}, Квадрат суммы: {squareOfSum}");
    }
}