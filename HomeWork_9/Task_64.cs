// Задача 64

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int NumberOutput(int n)
{
    if(n == 1) return 1;
    else return  NumberOutput(n - 1) + 1;   
}
for (int i = n; i > 0; i--)
{
    Console.Write($"{NumberOutput(i)} ");
}


