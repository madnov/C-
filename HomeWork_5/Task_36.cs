// Задача 36
Console.Clear();

int[] array = new int[5];
Random random = new Random();

for (int i = 0; i < array.Length; i++)
    array[i] = random.Next(-100,100);

foreach (int el in array)
    Console.Write($"{el} ");
Console.WriteLine();

int FindSumm(int[] arr)
{
    int total = 0;
    for (int i = 1; i < array.Length; i += 2)
        total += array[i];

    return total;
}
Console.WriteLine(FindSumm(array));