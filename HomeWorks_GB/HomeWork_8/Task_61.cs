// Задача 61 - Равнобедренный треугольник Паскаля

int row = 7;
int[,] triangle = new int[row, row];

void FillPrintTriangle(int[,] trianlge)
{
    for (int k = 0; k < row; k++)
    {
        int n = 1;
        for (int i = 0; i < row - k; i++)
            Console.Write("   ");

        for (int j = 0; j <= k; j++)
        {
            Console.Write($"     {n}");
                n = n * (k - j) / (j + 1);
        }
        Console.WriteLine();
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Clear();
FillPrintTriangle(triangle);