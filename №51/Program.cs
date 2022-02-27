// Задать двумерный массив следующим правилом: Aₘₙ = m+n

Console.Clear();
Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());
int [,] array = new int [m,n];


for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array [i,j] = i  +  j;
        Console.Write(array[i,j]+ "\t ");
    }
    Console.WriteLine();
}


/* Console.Write($"Введите номер Y от 0 до {m -1}: ");
int y = int.Parse(Console.ReadLine());
Console.Write($"Введите номер X от 0 до {n -1}: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("кординаты для первой точки: "+ array[x,y]);

Console.WriteLine();
Console.Write($"Введите номер Y от 0 до {m -1}: ");
int y1 = int.Parse(Console.ReadLine());
Console.Write($"Введите номер X от 0 до {n -1}: ");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("кординаты для первой точки: " + array[x1,y1]);
A = array[x,y] + array[x1,y1];
Console.WriteLine("Сумма 2 точек: " + A); */