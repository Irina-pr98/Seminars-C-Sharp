/* Напишите программу, которая принимает на вход координаты точки (X и Y), причем X != 0 и Y != 0 и выдает номер
    черверти плоскости, в которой находится эта точка */

Console.Clear();

Console.Write("Введите координату X: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y: ");
double y = Convert.ToDouble(Console.ReadLine());

while ( x == 0)
{
    Console.Write("Вы ошиблись!\nВведите координату X: ");
    x = Convert.ToDouble(Console.ReadLine());
}
while ( y == 0)
{
    Console.Write("Вы ошиблись!\nВведите координату Y: ");
    y = Convert.ToDouble(Console.ReadLine());
}
if (x > 0 && y > 0)
    Console.WriteLine("I четверть");
else if (x < 0 && y > 0)
    Console.WriteLine("II четверть");
else if (x < 0 && y < 0)
    Console.WriteLine("III четверть");
else
    Console.WriteLine("IV четверть");