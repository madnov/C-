// Задача 34
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100,1000);
}
int ReleaseArray(int[] array)
{   
    int count = 0;
    foreach (int el in array)
        if (el % 2 == 0) count++;
    return count;    
}

Console.Clear();
int[] array = new int[10];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine(ReleaseArray(array));