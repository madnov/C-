// Задача 61 - Равнобедренный треугольник Паскаля

int row = 9;
int[,] triangle = new int[row, row];
const int cellWidth = 3;

void FillTriangle(int[,] trianlge)
{
    for (int i = 0; i < row; i++)
    { 
        triangle[i, 0] = 1;
        triangle[i, i] = 1;
    }

    for (int i = 2; i < row; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            triangle[i,j] = triangle[i - 1, j - 1] + triangle[i - 1, j];
        }
    }
}

void PrintTriangle(int[,] triangle)
{
    for (int i = 0; i < triangle.GetLength(0); i++)
        {         
            for (int j = 0; j < triangle.GetLength(1); j++)
            if (triangle[i, j] != 0)
                Console.Write($"{triangle[i, j]} \t");
                
        Console.WriteLine();        
        }
}
Console.Clear();
FillTriangle(triangle);
PrintTriangle(triangle);