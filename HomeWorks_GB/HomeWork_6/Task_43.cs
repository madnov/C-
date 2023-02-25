// Задача 43

Console.Clear();
Console.Write("Введите значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double result1 = k1 * x + b1;
double result2 = k2 * x + b2;
Console.WriteLine($"Координаты точки пересечения: ({result1}; {result2})"); 

