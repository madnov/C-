// Задача 68

int AckerFunct(int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return AckerFunct(m - 1, 1);
    if (m > 0 && n > 0) return AckerFunct(m - 1, AckerFunct(m, n - 1));
    return AckerFunct(m, n);
}

Console.Clear();
Console.Write("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(AckerFunct(m, n));