// Задача 58
               
void ProductOfTwoMatrix(int[,] matrix1, int[,] matrix2, int[,] product)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                product[i, j] = 0;

                for (int k = 0; k < matrix1.GetLength(0); k++)
                {
                    product[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }   
}

void PrintMatrix(int[,] product)
{
    for (int i = 0; i < product.GetLength(0); i++)
    {
        for (int j = 0; j < product.GetLength(1); j++)
        {
            Console.Write($"{product[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();

int[,] matrix1 = {  {2, 4, 5},
                    {3, 2, 6},
                    {4, 1, 6}
                 };
int[,] matrix2 = {  {3, 4, 1},
                    {3, 3, 3},
                    {4, 5, 6}
                 };
int[,] product = new int[3,3];
ProductOfTwoMatrix(matrix1, matrix2, product);
PrintMatrix(product); 
