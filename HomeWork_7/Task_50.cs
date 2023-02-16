// Задача 50    

Console.Clear();
int [,] array = {
                    {1, 4, 7, 2},
                    {5, 9, 2, 3},
                    {8, 4, 2, 4}
                };
Console.Write("Введите номер строки: ");
int row = Convert.ToInt32(Console.ReadLine());                   
Console.Write("Введите номер столбца: ");
int col = Convert.ToInt32(Console.ReadLine());
try 
{
    Console.WriteLine(array[row,col]);
}
catch(IndexOutOfRangeException)
{
    Console.WriteLine("Такого элемента в массиве нет! ");
} 