﻿// Задача 38

Console.Clear();

double[] array = {34.3, 85.8, 43.3, 8.5, 30.34, 2.3};

void FindDifference(double[] arr)
{
    double max = 0;
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];   
    }
    double result = max - min;
    Console.WriteLine(max);
    Console.WriteLine(min);
    Console.WriteLine(result);
}

FindDifference(array);