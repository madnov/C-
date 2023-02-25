// Дополнительная задача - Транспонирование
void FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = new Random().Next(1,101);
            }
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

void ReverseMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i != matrix.GetLength(0) - 1)
            {
                int temp = matrix[i, j];
                matrix[i, j] = matrix[i + 1, j];
                matrix[i + 1, j] = temp;
            }
        }
    }
      
}

Console.Clear();
Console.Write("Введите элементы массива: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int [,] matrix = new int[size[0],size[1]];

FillMatrix(matrix);
PrintMatrix(matrix);
ReverseMatrix(matrix);
PrintMatrix(matrix);