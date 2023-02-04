// Задача 19
Console.Clear();

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
while (number < 10000 || number > 99999)
    {
        Console.Write("Ошибка!\nВведите пятизначное число: ");
        number = Convert.ToInt32(Console.ReadLine());
    }    
int num1 = number / 10000;
int num2 = (number / 1000) % 10;
int num3 = number % 10;
int num4 = (number / 10) % 10;
if (num1 == num3 && num2 == num4)
    Console.WriteLine("да");
else
    Console.WriteLine("нет");