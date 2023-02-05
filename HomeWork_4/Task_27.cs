// Задача 27
Console.Clear();

Console.Write("Введите число: ");
string? n = Console.ReadLine();
int  result = 0;


for(int i = 0; i < n.Length; i++)

    result += Convert.ToInt32(n[i].ToString());  
    
Console.WriteLine(result);