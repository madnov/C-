Console.Clear();

int FindSumm(int[]arr)
{
    int total = 0;
    for (int i = 0; i < arr.Length; i++)
        total += arr[i];
    return total;    
}

int[] array = {2, 45, 64, 61, 4, 7, 8, 97};

Console.WriteLine(FindSumm(array));