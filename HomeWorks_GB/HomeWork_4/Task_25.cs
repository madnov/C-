// Задача 25
Console.Clear();

Console.Write("Введите первое число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n2 = Convert.ToInt32(Console.ReadLine());
int result = 1;

for (int i = 1; i <= n2; i++)
{
    result *=  n1;
}

Console.WriteLine(result);