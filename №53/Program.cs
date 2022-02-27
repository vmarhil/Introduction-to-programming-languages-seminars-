// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет
Console.Clear(); 
Console.Write("Введите количество строк: "); 
int n = int.Parse(Console.ReadLine()); 
Console.Write("Введите количество столбцов: "); 
int m = int.Parse(Console.ReadLine()); 
int[,] mass = new int[n, m]; 
 
for (int i = 0; i < mass.GetLength(0); i++) 
{ 
    for (int j = 0; j < mass.GetLength(1); j++) 
    { 
        mass[i, j] = new Random().Next(0, 10); 
        Console.Write(mass[i, j] + "\t "); 
 
    } 
    Console.WriteLine(); 
} 
Console.WriteLine("Введите число: "); 
bool result = false;
int num = int.Parse(Console.ReadLine());
for (int i = 0; i < mass.GetLength(0); i++) 
{ 
    for (int j = 0; j < mass.GetLength(1); j++) 
    { 
            if (mass[i, j] == num)
            {
                Console.WriteLine($"Число {num} находится на: строка: {i}, столбец: {j}"); 
                result=true;
            }
    }  
} 
if(!result)
    {
        Console.WriteLine($"Число {num} нет в массиве");
    }



/* Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());
int [,] array = new int [m,n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array [i,j] = new Random().Next(0, 10);
        Console.Write(array[i,j]+ "\t ");
    }
    Console.WriteLine();
}

Console.Write($"Введите номер Y от 0 до {m -1}: ");
int y = int.Parse(Console.ReadLine());
Console.Write($"Координаты X от 0 до {n -1}: ");
int x = int.Parse(Console.ReadLine());
if (m < y || n < x)
{
    Console.WriteLine("Такой точки нет");
}
else
{
Console.WriteLine();
Console.WriteLine("кординаты точки: "+ array[x,y]);
Console.WriteLine();
} */