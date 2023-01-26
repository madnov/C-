// Задача 2
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
    
if(number1 > number2)
{
    Console.Write("max = ");
    Console.WriteLine(number1);
}
else
{
    Console.Write("max = ");
    Console.WriteLine(number2);
}