/* Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
    второй и предпоследний и т.д. Результат запишите в новом массиве.
    [1 2 3 4 5] -> 5 8 9
    [6 7 3 6] -> 36 21 */

// нечетное: 5 / 2 + 1 - количество элементов / 2 + оставшийся элемент
// четное: 4 / 2 + 0 - количество элементов / 2 + оставшийся элемент

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 11); // [1, 10]
}


void ReleaseArray(int[] array)
{
    for (int i = 0; i < array.Length / 2 + array.Length % 2; i++)
    Console.Write($"{array[i] * array[array.Length - 1 - i]} ");
    // i = 0    a[0] * a[4]    a[1] * a[3]    a[2] * a[2]
}


Console.Clear();

Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];

InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
ReleaseArray(array);

/*
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 11); // [1, 10]
}


int[] ReleaseArray(int[] array)
{
    int[] result = new int [array.Length / 2 + array.Length % 2];
    for (int i = 0; i < array.Length / 2 + array.Length % 2; i++)
        result[i] = array[i] * array[array.Length - 1 - i];
    return result;
}

Console.Clear();

Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];

InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Конечный массив: [{string.Join(", ", ReleaseArray(array))}]"); */