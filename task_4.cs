// Задача 4
List<int> numbers = new List<int>();
for(int i = 1; i <= 3; i++)
{
    Console.Write("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    numbers.Add(num);
}
int max = numbers[0];
if(numbers[1] > max) max = numbers[1];
if(numbers[2] > max) max = numbers[2];

Console.Write("max = ");
Console.WriteLine(max);