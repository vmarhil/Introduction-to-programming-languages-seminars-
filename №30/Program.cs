// Показать кубы чисел, заканчивающихся на четную цифру


Console.Clear();
Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите число c: ");
int c = int.Parse(Console.ReadLine());
Console.Write("Введите число d: ");
int d = int.Parse(Console.ReadLine());
int Qb_a = Convert.ToInt32(Math.Pow(a, 3)); 
int Qb_b = Convert.ToInt32(Math.Pow(b, 3));
int Qb_c = Convert.ToInt32(Math.Pow(c, 3));
int Qb_d = Convert.ToInt32(Math.Pow(d, 3));
Console.WriteLine();
while (a > 10 )
{
    a = a % 10;  
}
while (b > 10 )
{
    b = b % 10;  
}
while (c > 10 )
{
    c = c % 10;  
}
while (d > 10 )
{
    d = d % 10;  
}
if (a % 2==1)
{
    Console.WriteLine("число a нечетное");
}
else
{
    Console.WriteLine("Число четное, куб числа a = "  + Qb_a);
}


if (b % 2==1)
{
    Console.WriteLine("число b нечетное");
    }
else
{
    Console.WriteLine("Число четное, куб числа b = "  + Qb_b);
}


if (c % 2==1)
{
    Console.WriteLine("число  c нечетное");
    }
else
{
    Console.WriteLine("Число четное, куб числа c = "  + Qb_c);
}

if (d % 2==1)
{
    Console.WriteLine("число d нечетное");
    }
else
{
    Console.WriteLine("Число четное, куб числа d = "  + Qb_d);
    
}

