Console.Clear();

int cpuNumber = new Random().Next(1,101);
Console.Write("Введите число от 1 до 100: ");
int plNumber = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (cpuNumber != plNumber)
{ 
    if (cpuNumber > plNumber)
    {
        Console.Write("Загаданное число больше, попробуйте ещё: ");
        plNumber = Convert.ToInt32(Console.ReadLine());
        count++;
    }    
    else if (cpuNumber < plNumber)
    {
        Console.Write("Загаданное число меньше, попробуйте ещё: ");
        plNumber = Convert.ToInt32(Console.ReadLine());
        count++;
    } 
       
}
Console.WriteLine($"Поздравляем вы угадали c {count} раза, это число {cpuNumber}");