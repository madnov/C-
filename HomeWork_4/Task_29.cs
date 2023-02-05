// Задача 29
Console.Clear();

Console.Write("Введите количество учеников: ");
int count = Convert.ToInt32(Console.ReadLine());
while (count < 1 || count > 100)
{
    Console.Write("Введите количество учеников(не более 100): ");
    count = Convert.ToInt32(Console.ReadLine());
}
int[] array = new int [count];
for (int i = 0; i < count; i++)
{
    Console.Write("Введите рост учеников по убыванию: ");
    int h = Convert.ToInt32(Console.ReadLine());
    array[i] = h;
}
Console.Write("Введите рост: ");
int height =Convert.ToInt32(Console.ReadLine());

int total = 1;
for (int i = 0; i < array.Length; i++)
{
    if (height <= array[i]) total++;
}
Console.WriteLine(total);