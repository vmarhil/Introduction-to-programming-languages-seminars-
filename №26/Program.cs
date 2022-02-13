// Возведите число А в натуральную степень B используя цикл
Console.Clear();
Console.WriteLine("Введите число x: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень n: ");
int n = int.Parse(Console.ReadLine());
int y = 1;
//int i = Convert.ToInt32(Math.Pow(x, n));
//Console.WriteLine("x в степине n = " + i);
for (int i = 1; i <= n ; i++)
{
    y = y*x;
}
Console.Write(y);