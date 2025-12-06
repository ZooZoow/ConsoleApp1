using System;

class ArrayExample
{
    static void Main()
    {
        char[] letters = { 'f', 'r', 'e', 'd', ' ', 's', 'm', 'i', 't', 'h' };

        if (letters.Length == 0)
        {
            Console.WriteLine("Массив букв пуст.");
            return;
        }

        string name = new string(letters);

        for (int i = 1; i <= letters.Length; i++)
        {
            SendMessage(name, i);
        }

        Console.ReadKey();
    }

    static void SendMessage(string name, int count)
    {
        Console.WriteLine($"Hello, {name}! Count to {count}");
    }
}
