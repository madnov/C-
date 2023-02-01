// Задача 23
Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int total = 1;
int result = 0;

for (int i = 1; i <= number; i++)
{
     result = total * total * total;
     total++;
     Console.WriteLine(result);
}     