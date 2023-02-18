// Дополнительная задача - Заполнение диагоналями.

void FillMatrix (int[,] matrix)
{
    int count = 0;
    for (int k = 0; k < matrix.GetLength(0) * matrix.GetLength(1);k++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (i + j == k)
                {
                    matrix[i, j] = count;
                    count++;
                }
            }
        }
    }               
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
Console.Clear();
Console.Write("Введите элементы массива: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int [,] matrix = new int[size[0],size[1]];

FillMatrix(matrix);
PrintMatrix(matrix);
