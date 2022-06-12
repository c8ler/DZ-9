/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

bool run = true;
while (run)
{

    Console.Clear();
    Console.Write("Задайте целое значение M: ");
    int numM = int.Parse(Console.ReadLine());
    Console.Write("Задайте целое значение N: ");
    int numN = int.Parse(Console.ReadLine());

    NaturalSum(numM, numN, 0);

    Console.WriteLine();
    Console.WriteLine("Попробуем ещё раз? (y/n): ");
    run = Console.ReadKey().Key == ConsoleKey.Y;
}

void NaturalSum(int m, int n, int sum)
{
    if (m > n)
    {
        int temp = n;
        n = m;
        m = temp;
    }
    if (m == n)
    {
        Console.WriteLine($"Сумма чисел = {sum + n}");
        return;
    }
    sum += m;
    m++;
    NaturalSum(m, n, sum);
}