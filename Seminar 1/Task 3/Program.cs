/* /* Напишите программу, которая будет выдавать название дня недели по заданному номеру
    3 -> среда
    5 -> пятница */

Console.Clear();

Console.Write("Введите день недели: ");
int n = Convert.ToInt32(Console.ReadLine());

while (n < 1 || n > 7)
{
    Console.Write("Вы ошиблись!\nВведите день недели: "); // \n - переход на новую строку
    n = Convert.ToInt32(Console.ReadLine());
}
if (n == 1)
    Console.Write("Понедельник");
else if (n == 2)
    Console.Write("Вторник");
else if (n == 3)
    Console.Write("Среда");
else if (n == 4)
    Console.Write("Четверг");
else if (n == 5)
    Console.Write("Пятница");
else if (n == 6)
    Console.Write("Суббота");
else
    Console.Write("Воскресенье");