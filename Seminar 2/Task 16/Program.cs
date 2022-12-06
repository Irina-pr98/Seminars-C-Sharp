/* Напишите программу, которая на вход принимает два числа и проверяет, является ли одно число
    квадратом другого
    5, 25 -> да
    -4, 16 -> да
    25, 5 -> да
    8, 9 -> нет */

Console.Clear();

Console.Write("Введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int m = Convert.ToInt32(Console.ReadLine());

if (m * m == n || n * n == m)
    Console.WriteLine("Да");
else
    Console.WriteLine("Нет");