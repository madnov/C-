// Дополнительная задача 1(не решена)

int FindResult(int number,string symbols)
{
    if (number == 1) return 1;
      string = 
}
int FindFactorial(int lenght)
{
   if (lenght == 1) return 1;
   else
      return   lenght = lenght * FindFactorial(lenght - 1);      
}

Console.Clear();
Console.Write("Введите несколько латинских символов(не более 8): ");
string symbols = Console.ReadLine();
while(symbols.Length <= 0 || symbols.Length >= 9)
{
    Console.Write("Вы ввели недопустимое количество символов!\nПовторите попытку: ");
    symbols = Console.ReadLine();
}
int lenght = symbols.Length;
FindFactorial(lenght);  
int number =(FindFactorial(lenght));  
Console.WriteLine(symbols);
FindResult(number, symbols);