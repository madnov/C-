// Задача 21
Console.Clear();
Console.Write("Введите первую координату А: ");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вторую координату А: ");
int a2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третью координату А: ");
int a3 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите первую координату B: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вторую координату B: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третью координату B: ");
int b3 = Convert.ToInt32(Console.ReadLine());

 int res1 = a1 - b1;
 int res2 = a2 - b2;
 int res3 = a3 - b3;

int res4 = (res1 * res1) + (res2 * res2) + (res3 * res3);
double result = Math.Sqrt(res4);

Console.WriteLine(result);