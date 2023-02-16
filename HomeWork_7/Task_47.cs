// Задача 47

void FillArray (double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] =  new Random().Next(-5,20) / 2.5;
        
       
}

void PrintArray(double[,] array)
{
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
Console.Write("Введите количество строк в двумерном массиве: ");   
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());
double[,] array = new double [rows, cols];

FillArray(array);
PrintArray(array);