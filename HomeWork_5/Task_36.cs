// Задача 36
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100,100);
}

int FindSumm(int[] array)
{
    int total = 0;
    for (int i = 1; i < array.Length; i += 2)
        total += array[i];

    return total;
}
Console.Clear();
int[] array = new int[5];
InputArray(array);
Console.WriteLine($"[{string.Join(", ",array)}]");
Console.WriteLine(FindSumm(array));