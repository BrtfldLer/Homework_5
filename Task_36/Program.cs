
// Задача 36. Массив случайных чисел. Найти сумму элементов, стоящих на нечётных позициях
int amount = new Random().Next(0, 10);
int[] array = new int [amount];
int len = array.Length;
int count = 0;

for (int i = 0; i<len; i++)
{
array[i] = new Random().Next(-10,10);
Console.Write($"{array[i]} ");
if (i % 2 != 0)
{
    count = count + array[i];
}
}
Console.WriteLine();
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях в данном массиве, равна {count}");
