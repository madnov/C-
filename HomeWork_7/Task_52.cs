// Задача 52

void FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 10);
    }
}

void FindAverage(int[,] matrix)
{
    Console.WriteLine("Cреднее арифметическое столбцов:");
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double total = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            total += matrix[j, i];
        }
        Console.Write($"{Math.Round(total / matrix.GetLength(0), 2)} \t");
    }
}

void PrintMatrix(int[,] matrix)
{
    Console.WriteLine("Заданный двумерный массив:");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размер массива: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];

FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
FindAverage(matrix);