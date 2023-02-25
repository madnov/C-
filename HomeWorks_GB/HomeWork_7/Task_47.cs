// Задача 47

void FillMatrix (double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] =  new Random().Next(-5,20) / 2.5;    
}

void PrintMatrix(double[,] matrix)
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

Console.Clear();
Console.Write("Введите размер массива: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
double[,] matrix = new double[size[0], size[1]];

FillMatrix(matrix);
PrintMatrix(matrix);