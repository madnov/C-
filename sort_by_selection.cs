void SortSelection(int[] collection)
{
    int size = collection.Length;
    for (int i = 0; i < size - 1; i++)
    {
        int pos = i;
        for (int j = i + 1; j < size; j++)
        {
            if (collection[j] < collection[pos]) pos = j;
        }
        int temp = collection[i];
        collection[i] = collection[pos];
        collection[pos] = temp;
    }
    
}

int[] collection = {2, 4, 1, 3, 9, 6, 7};
SortSelection(collection);
Console.WriteLine($"[{string.Join(", ",collection)}]");