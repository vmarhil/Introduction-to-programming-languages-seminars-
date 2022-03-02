// Найти произведение двух матриц


Console.Clear();
Console.WriteLine();
Random random = new Random();
int[,] array = new int[2, 2];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = random.Next(-10, 10);
    }
    Console.WriteLine();

}
Console.WriteLine("Первая матрица: ");
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();

}
Console.WriteLine("========================================");
int[,] array2 = new int[2, 2];
for (int i = 0; i < array2.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        array2[i, j] = random.Next(-10, 10);
    }
    Console.WriteLine();

}
Console.WriteLine("Вторая матрица");
for (int i = 0; i < array2.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        Console.Write(array2[i, j] + "\t");
    }
    Console.WriteLine();

}
Console.WriteLine("========================================");
Console.WriteLine("Произведение двух матриц: ");
int a11 = array[0,0];
int a12 = array[0,1];
int a21 = array[1,0];
int a22 = array[1,1];

int b11 = array[0,0];
int b12 = array[0,1];
int b21 = array[1,0];
int b22 = array[1,1];

int[,] array3 = new int[2, 2];
array3[0,0] = a11*b11+a12*b21;
array3[0,1] = a11*b12+a12*b22;
array3[1,0] = a21*b11+a21*b21;
array3[1,1] = a21*b12+a22*b22;

for (int i = 0; i < array3.GetLength(0); i++)
{
    for (int j = 0; j < array3.GetLength(1); j++)
    {
        Console.Write(array3[i,j] + "\t");
    }
    Console.WriteLine();

}



