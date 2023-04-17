using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите двузначное число: ");
        int num = int.Parse(Console.ReadLine());

        int tens = num / 10; // находим десятки
        int ones = num % 10; // находим единицы

        Console.WriteLine($"Левая цифра: {tens}");
        Console.WriteLine($"Правая цифра: {ones}");
    }
}
