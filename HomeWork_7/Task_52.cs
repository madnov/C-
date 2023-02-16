// Задача 52

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)    
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(1,30);   
}

void FindSum(int[,] array)
{
       
}
void PrintArray(int[,] array)
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
int [,] array = new int[5, 4];
FillArray(array);
PrintArray(array);
FindSum(array);
