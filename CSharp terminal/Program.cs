// Задача 52

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(1, 10);
}

void FindAverage(int[,] array)
{
    Console.WriteLine("Cреднее арифметическое\nстолбцов: ");
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double total = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            total += array[j, i];
        }
        Console.Write($"{Math.Round(total / array.GetLength(0), 2)}; ");
    }
}

void PrintArray(int[,] array)
{
    Console.WriteLine("Заданный двумерный\nмассив: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];

FillArray(array);
PrintArray(array);
Console.WriteLine();
FindAverage(array);