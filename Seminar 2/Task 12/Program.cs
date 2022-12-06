/* Напишите программу, которая будет принимать на вход два числа и выводить,является ливторое число
    кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления
    34, 5 -> не кратно, остаток 4
    16, 4 -> кратно */

Console.Clear();

Console.Write("Введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int m = Convert.ToInt32(Console.ReadLine());

if (n % m == 0)
    Console.WriteLine("Кратно");
else
    Console.WriteLine($"Не кратно, остаток {n %  m}");