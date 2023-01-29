// Задача 13
Console.Clear();
Console.Write("Введите число(не более пятизначного): ");
int number = Convert.ToInt32(Console.ReadLine());
int res = 0;

if (number / 100 == 0)
    Console.WriteLine("третьей цифры нет");

else if (number / 100 > 0 && number / 100 < 10)
{
    res = number % 10;
    Console.WriteLine(res);    
}
else if (number / 1000 > 0 && number / 100 < 100)
{
    res = (number / 10)  % 10;
    Console.WriteLine(res);    
}
else if (number / 10000 > 0 && number / 100 < 1000)
{
    res = (number / 100)  % 10;
    Console.WriteLine(res);    
}
else
    Console.WriteLine("Введено большое число!");