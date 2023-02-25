// Задача 41

void Result(int[] numbers)
{
  int count = 0;
    foreach(int el in numbers)
      if (el > 0) count++;  
  Console.WriteLine($"Было введено {count} числа(ел) больше 0");    
}

Console.Clear();
Console.Write("Введите несколько чисел через пробел: ");
int[] numbers = Console.ReadLine().Split().Select(i => int.Parse(i)).ToArray();

Result(numbers);