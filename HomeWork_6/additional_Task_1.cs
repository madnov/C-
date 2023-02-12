// Дополнительная задача 1

void Result(string symbols)
{
    string change = string.Empty;
    for(int i = 0; i < symbols.Length; i++)
       
 Console.WriteLine();
}

Console.Clear();
Console.Write("Введите несколько латинских символов(не более 8): ");
string symbols = Console.ReadLine();
while(symbols.Length <= 0 || symbols.Length >= 9)
{
    Console.Write("Вы ввели недопустимое количество символов!\nПовторите попытку: ");
    symbols = Console.ReadLine();
}    
Console.WriteLine(symbols); 
Result(symbols);
