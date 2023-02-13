// Дополнительная задача 1(не решена)

void FinsdResult(string symbols,int lenght)
{
    string change = string.Empty;
    for(int i = 0; i < Math.Pow(symbols.Length, symbols.Length); i++)
       
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
FindResult(symbols);
