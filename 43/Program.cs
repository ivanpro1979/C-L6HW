// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Console.Clear();

Console.Write("Введите через пробел b1, k1, b2, k2: ");
string[] f = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
double b1 = double.Parse(f[0]);
double k1 = double.Parse(f[1]);
double b2 = double.Parse(f[2]);
double k2 = double.Parse(f[3]);
if (b1 == b2 && k1 != k2)
{
    Console.WriteLine($"Точка пересечения прямых: (0; {b1})");
}
else if (b1 == b2 && k1 == k2)
{
    Console.WriteLine("Прямые совпадают");
}
else
{
    double x = (b1 - b2) / (k2 - k1);
    double y = (k1 * x + b1);
    Console.WriteLine($"Точка пересечения прямых: ({x}; {y})");
}