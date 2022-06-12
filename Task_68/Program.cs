/* Задача 68: Напишите программу вычисления функции Аккермана с помощью
рекурсии. Даны два неотрицательных числа m и n.
m = 3, n = 2 -> A(m,n) = 29 */

bool run = true;
while (run)
{

    Console.Clear();
    Console.Write("Задайте целое значение m функции Аккермана: ");
    double numM = double.Parse(Console.ReadLine());
    Console.Write("Задайте целое значение n функции Аккермана: ");
    double numN = double.Parse(Console.ReadLine());

    double res = Akkerman(numM, numN);

    Console.WriteLine(res);
    Console.WriteLine("Попробуем ещё раз? (y/n): ");
    run = Console.ReadKey().Key == ConsoleKey.Y;
}

double Akkerman(double m, double n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return Akkerman(m - 1, 1);
    if (m > 0 && n > 0) return Akkerman(m - 1, Akkerman(m, n - 1));
    return Akkerman(m, n);
}