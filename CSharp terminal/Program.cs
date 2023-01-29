// Дополнительная задача
Console.Clear();
Console.Write("Введите число (не меньше трёхзначного): ");
int number = Convert.ToInt32(Console.ReadLine());
int res = 0;

if (number >= 100 && number <= 999)
    {
    res = number % 10;
    Console.WriteLine(res);
    }
else if (number < 100)

    Console.WriteLine("Число не является трёхзначным");    

while (number > 1000) 
{
    number /= 10;   
    if (number < 1000)
    { 
    res = number % 10;
    Console.WriteLine(res);
    }
}


