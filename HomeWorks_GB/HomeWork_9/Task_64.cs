// Задача 64

string NumberOutput(int n)
{
    if(n == 1) return "1";
    return $"{n}, " + NumberOutput(n - 1);   
}
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(NumberOutput(n));
