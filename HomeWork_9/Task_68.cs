// Задача 68

Console.Clear();
Console.Write("Введите два числа: ");
int[] s = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

int AckerFunct(int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return AckerFunct(m - 1, 1);
    if (m > 0 && n > 0) return AckerFunct(m - 1, AckerFunct(m, n - 1));
    return AckerFunct(m, n);
}

Console.WriteLine(AckerFunct(s[0], s[1]));