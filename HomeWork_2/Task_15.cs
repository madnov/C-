// Задача 15
Console.Clear();
Console.Write("Введите цифру от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());
while ( number < 1 || number > 7)
{
    Console.Write("Вы ошиблись!\nВведите цифру от 1 до 7: ");
    number = Convert.ToInt32(Console.ReadLine());
}

if (number == 1 || number == 2 || number == 3 || number == 4 || number == 5)

    Console.WriteLine("нет");

else

    Console.WriteLine("да");
    