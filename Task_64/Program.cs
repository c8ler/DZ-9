/* Задача 64: Задайте значение N. Напишите программу, которая выведет все
натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

bool run = true;
while (run)
{

    Console.Clear();
    Console.Write("Задайте целое значение N: ");
    int n = int.Parse(Console.ReadLine());
    int count = 1;
    NaturalNumber(n, count);

    Console.WriteLine();
    Console.WriteLine("Попробуем ещё раз? (y/n): ");
    run = Console.ReadKey().Key == ConsoleKey.Y;
}

void NaturalNumber(int num, int cnt)
{
    if (num <= 0) Console.Write($"Неверное значение! Введите целое N > 0.");
    else if (cnt == num) Console.Write($"{cnt} ");
    else if (cnt > 0)
    {
        NaturalNumber(num, cnt + 1);
        Console.Write($"{cnt} ");
    }
}