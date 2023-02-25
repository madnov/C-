// Задача 50    

Console.Clear();
int [,] matrix = {
                    {1, 4, 7, 2},
                    {5, 9, 2, 3},
                    {8, 4, 2, 4}
                };
Console.Write("Введите элементы массива: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

try 
{
    Console.WriteLine($"На данной позиции находится элемент: {matrix[size[0]-1,size[1]-1]}");
}
catch(IndexOutOfRangeException)
{
    Console.WriteLine("Такой позиции в массиве нет! ");
} 