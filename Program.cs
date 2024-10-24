using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] array = new int[20];

        Console.WriteLine("Оберіть спосіб заповнення масиву:");
        Console.WriteLine("1. Ввести з клавіатури");
        Console.WriteLine("2. Заповнити випадковими числами");

        string choice = Console.ReadLine();

        if (choice == "1")
        {
            array = InputFromKeyboard();
        }
        else if (choice == "2")
        {
            array = GenerateRandomArray();
        }
        else
        {
            Console.WriteLine("Невірний вибір. Програма завершена.");
            return;
        }

        Console.WriteLine("Масив: " + string.Join(", ", array));
        int sum = array.Where(x => x % 2 == 0).Sum();
        Console.WriteLine("Сума парних елементів: " + sum);
    }

    // Метод для введення з клавіатури
    static int[] InputFromKeyboard()
    {
        int[] array = new int[20];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Елемент {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }
        return array;
    }

    // Метод для генерації випадкових чисел
    static int[] GenerateRandomArray()
    {
        Random rand = new Random();
        return Enumerable.Range(0, 20).Select(x => rand.Next(-100, 101)).ToArray();
    }
}

