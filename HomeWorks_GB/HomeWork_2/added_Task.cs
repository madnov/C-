// Дополнительная задача
Console.Clear();
Console.Write("Введите числа от 0 до 100: ");
int number = Convert.ToInt32(Console.ReadLine());
int max1 = 0;
int max2 = 0;

while (number != 0)
{
    Console.Write("Введите числа от 0 до 100: ");
    number = Convert.ToInt32(Console.ReadLine());
    if (number > max1)
{ 
    max2 = max1;
    max1 = number;
 } 
    else if (number > max2) max2 = number;
}
Console.WriteLine("max_2 = "+ max2);
