// Задача 34
Console.Clear();

int[] array = new int[10];
Random random = new Random();

for (int i = 0; i < array.Length; i++)
    array[i] = random.Next(100,999);

int count = 0;
foreach(int el in array)
    Console.Write($"{el} ");

int FindEven(int[] arr)
{
    for (int i = 0; i < array.Length; i++)
        {
        if (array[i] % 2 == 0) count++;
        }
        return count;
}
Console.WriteLine();
Console.WriteLine(FindEven(array));