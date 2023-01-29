// Дополнительная задача
Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int res = 0;
while (number <= 100)
{
    Console.Write("Число не является трёхзначным\nВведите число: ");
    number = Convert.ToInt32(Console.ReadLine());
}    
while (number > 1000) 
{
    number /= 10;   
    if (number < 1000)
    { 
    res = number % 10;
    Console.WriteLine(res);
    }
}



