// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
Console.Clear();
Console.WriteLine("Введите точку b1: ");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите точку k1: ");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите точку b2: ");
double b2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите точку k2: ");
double k2 = double.Parse(Console.ReadLine());
Console.WriteLine();
double x = (b2 - b1)/(k1 - k2);
double y = k1*(b2-b1)/(k1-k2)+b1;
Console.Write($"точка пересечения двух прямых: ({x};{y})");
