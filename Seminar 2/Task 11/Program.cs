/* Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа
    456 -> 46
    782 -> 72
    918 -> 98 */

Console.Clear();

int n = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число {n}");

int n1 = n / 100; // количество сотен
int n3 = n % 10; // количество единиц

Console.WriteLine(n1 * 10 + n3);