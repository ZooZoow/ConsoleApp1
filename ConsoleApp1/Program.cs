using System;

class Program
{
    static void Main()
    {
        int result = Fibonacci(5);
        Console.WriteLine(result);
    }

    static int Fibonacci(int n)
    {
        
        if (n < 0)
            throw new ArgumentException("n должно быть неотрицательным");

        if (n == 0) return 0;
        if (n == 1) return 1;

        int n1 = 0;  
        int n2 = 1;  
        int sum;

        for (int i = 2; i <= n; i++)  
        {
            sum = n1 + n2;
            n1 = n2;
            n2 = sum;
        }

        return n2;
    }
}
