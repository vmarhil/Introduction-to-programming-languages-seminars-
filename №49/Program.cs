﻿// Показать двумерный массив размером m×n заполненный вещественными числами
Console.Clear();
Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());
double [,] array = new double [m , n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array [i,j] = new Random().NextDouble()* (10) ;
        Console.Write(array[i,j]+ " ");
    }
    Console.WriteLine();
} 

