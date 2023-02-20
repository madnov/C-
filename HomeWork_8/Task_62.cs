// Задача 62 - Заполнение спиралью

void FillMatrix(int[,] matrix)
{ 
    int cons = matrix.GetLength(0);
    int number = 1;  
    for (int k = 0; k < cons - 2 ; k++)
    {
        for(int i = 0 + k; i < cons - k; i++)
            matrix[0 + k, i] = number++;
        
        number--;

        for(int i = 0 + k; i < cons - k; i++)
            matrix[i, cons - 1 - k] = number++;    
            
        number--;

        for(int i = cons - 1 - k; i >= 0 + k; i--)
            matrix[cons - 1 - k, i] = number++;

        number--;

        for (int i = cons - 1 - k; i >= 1 + k; i--)
            matrix[i, 0 + k] = number++;   
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
int[,] matrix = new int[7, 7];
FillMatrix(matrix);
PrintMatrix(matrix);