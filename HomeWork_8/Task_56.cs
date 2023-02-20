// Задача 56 

void FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 20);
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void MinSumMatrix(int[,] matrix, int[] array)
{
    
    int total = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            total += matrix[i, j];
              
        }
        array[i] = total;
        total = 0;
    }
    
    Console.WriteLine($"[{string.Join(" ,", array)}]");
}

void FindMinArray(int[] array)
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
        {
           if (array[i] < min) min = array[i];
        }
    
    Console.WriteLine($"Наименьшая сумма элементов находится на {Array.IndexOf(array,min) + 1} строке.");
}


int[,] matrix = new int[5, 3];
int[] array = new int[matrix.GetLength(0)];
Console.Clear();
FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
MinSumMatrix(matrix,array);
Console.WriteLine();
FindMinArray(array);