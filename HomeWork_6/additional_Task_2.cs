// Дополнительная задача 2

void FindResult(double[] numbers)
{
    double x1 = numbers[0];
    double y1 = numbers[1];
    double x2 = numbers[2];
    double y2 = numbers[3];
    double x3 = numbers[4];
    double y3 = numbers[5];
    double result = 0.5 * Math.Abs(((x2 - x1)*(y3 - y1)) - ((x3- x2)*(y2- y1)));
    Console.WriteLine($"Площадь треугольника равна: {result}");
}   

Console.Clear();
Console.Write("Введите 6 точек координат вершин треугольника через пробел: ");
double[] numbers = Console.ReadLine().Split().Select(i =>double.Parse(i)).ToArray();

FindResult(numbers);