// Задача 66

Console.Clear();
Console.Write("Введите два числа: ");
int[] s = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

int FindSumm(int n)
{
    if(n == s[0]) return s[0];
    else return n + FindSumm(n - 1);         
}

Console.Write($"Сумма чисел от {s[0]} до {s[1]} = {FindSumm(s[1])}");
