// Дополнительная задача
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1,32);
    Console.WriteLine($"[{string.Join(", ",array)}]");    
}

void FindResult(int[] array)
{
    string even = string.Empty;
    string odd = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) even += array[i].ToString() + " ";
        else    
            odd += array[i].ToString() + " ";
    }
    Console.WriteLine(odd);
    Console.WriteLine(even);
     
    if (even.Length > odd.Length) Console.WriteLine("YES");
        else
            Console.WriteLine("NO");     
}

Console.Clear();
Console.Write("Введите количество элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

InputArray(array);
FindResult(array);