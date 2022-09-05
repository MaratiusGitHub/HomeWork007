// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] NewRandomArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max);
        }
    }
    return result;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[] GetArrayFromString(string element)
{
    string[] nums = element.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[nums.Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = int.Parse(nums[i]);
    }
    return result;
}

void findNumber(int[,] massive, int[] arr)
{
    int number = massive[arr[0], arr[1]];
    Console.WriteLine(number);
}


Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] myArray = NewRandomArray(rows, columns, 0, 10);
PrintArray(myArray);

Console.WriteLine("Введите индекс строки и столбца через пробел");
int[] index = GetArrayFromString(Console.ReadLine());

if (index[0] < rows & index[1] < columns)
{
    findNumber(myArray, index);
}
else
{
    Console.WriteLine("Такого элемента нет");
}
