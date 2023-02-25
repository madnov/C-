// Задача 66

int FindSumm(int m, int n)
{
    if(m == n) return m;
    return m + FindSumm(m + 1, n);         
}

Console.Write("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"Сумма чисел от {m} до {n} = {FindSumm(m, n)}");
