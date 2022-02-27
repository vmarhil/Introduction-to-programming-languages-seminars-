// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
Console.Clear();
Console.Write("Введите количество строк: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int m = int.Parse(Console.ReadLine());
int[,] array = new int[n, m];
double[] summ = new double[m];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        array[i, j] = new Random().Next(0, 10);  
        Console.Write(array[i, j] + "\t ");
    }
    Console.WriteLine();
}
Console.WriteLine();
for (int i = 0; i < n; i++)                   
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(array[i, j] + "\t");
        summ[j] += (array[i, j]);

    }
    Console.WriteLine();

}
Console.WriteLine("Сумма: ");
for (int i = 0; i < array.GetLength(1); i++) 
{
    Console.Write(summ[i] + "\t");
}
Console.WriteLine();
Console.WriteLine("Среднее арифметическое столбца: ");


for (int i = 0; i < array.GetLength(1); i++)  
{
    Console.Write( summ[i] / m  + "\t");
}




