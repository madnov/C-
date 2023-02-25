// Задача 66

int FindSumm(int a, int b)
{
    if(b == 0) return 1;
    return a * FindSumm(a, b - 1);         
}

Console.Clear();
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write($"{a} возведённое в степень {b} = {FindSumm(a, b)}");

