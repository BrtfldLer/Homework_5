// Задача 38. Массив вещественных чисел. Найти разницу между максимальным и минимальным элементом массива

// Закомментированный вариант для INT. Ниже - для DOUBLE

// Как сделать рандом для вещественных чисел?) 

// Посмотрела Ваше решение этой задачи, не очень поняла принцип использования "Res".
// Можно ли как-то вытащить результат метода за его пределы, чтобы использовать моё решение и найти разность в конце?


// void SearchMax(int[] arr)
// {
//     int max = arr[0];
//     for (int j =0; j<arr.Length; j++)
//     {
//     if (arr[j] > max)
//     {
//     max = arr[j];
//     }
//     }
//     Console.WriteLine(max);
// }

// void SearchMin(int[] arr)
// {
//     int min = arr[0];
//     for (int j =0; j<arr.Length; j++)
//     {
//     if (arr[j] < min)
//     {
//     min = arr[j];
//     }
//     }
//     Console.WriteLine(min);
// }

// int amount = new Random().Next(5, 10);
// int[] array = new int [amount];
// int len = array.Length;
// for (int i = 0; i<len; i++)
// {
// array[i] = new Random().Next(-10,10);
// Console.Write($"{array[i]} ");
// }
// Console.WriteLine();
// Console.Write("Максимальное значение равно: ");
// SearchMax (array);
// Console.Write("Минимальное значение равно: ");
// SearchMin (array);


void SearchMax(double[] arr)
{
    double max = arr[0];
    for (int j =0; j<arr.Length; j++)
    {
    if (arr[j] > max)
    {
    max = arr[j];
    }
    }
    Console.WriteLine(max);
}

void SearchMin(double[] arr)
{
    double min = arr[0];
    for (int j =0; j<arr.Length; j++)
    {
    if (arr[j] < min)
    {
    min = arr[j];
    }
    }
    Console.WriteLine(min);
}

double[] array = {1.2, 7.6, -8.1, -8.3, 8.7};
int len = array.Length;
for (int i = 0; i<len; i++)
{
Console.Write($"{array[i]} ");
}
Console.WriteLine();
Console.Write("Максимальное значение равно: ");
SearchMax (array);
Console.Write("Минимальное значение равно: ");
SearchMin (array);