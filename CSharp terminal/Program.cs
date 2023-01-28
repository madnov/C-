// Задача 10
Console.Clear();
Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

while(number < 100 || number > 999 )
{
    Console.Write("Ошибка!\nВведите трёхзначное число: ");
    number = Convert.ToInt32(Console.ReadLine());
}
int result = (number / 10) % 10;

Console.WriteLine(result);