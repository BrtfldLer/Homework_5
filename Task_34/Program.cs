// Задача 34. Массив из случайных положительных трёхзначных чисел. 
// Показать количество чётных чисел

int amount = new Random().Next(0, 15);
int[] array = new int [amount];
int len = array.Length;
int count = 0;

for (int i = 0; i<len; i++)
{
array[i] = new Random().Next(100,1000);
Console.Write($"{array[i]} ");
    if (array[i] % 2 == 0)
    {
    count++;
    }
}
Console.WriteLine();
Console.WriteLine($"Количество чётных чисел в данном массиве равно {count}");
