/* Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
    a = 25, b = 5 -> да
    a = 2, b = 10 -> нет
    a = 9, b = 3 -> да
    a = -3, b = 9 -> нет */

Console.Clear();

Console.Write("Введите 1-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int m = Convert.ToInt32(Console.ReadLine());

if (m * m == n)
    Console.WriteLine("yes");
else
    Console.WriteLine("no");