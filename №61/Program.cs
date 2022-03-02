// Найти произведение двух матриц


Console.Clear();
Console.WriteLine();
Random random = new Random();
int[,] array = new int[2, 2];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = random.Next(5);
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
        array2[i, j] = random.Next(5);
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
int a00 = array[0,0];
int a01 = array[0,1];
int a10 = array[1,0];
int a11 = array[1,1];

int b00 = array2[0,0];
int b01 = array2[0,1];
int b10 = array2[1,0];
int b11 = array2[1,1];
int c1 = a00*b00;
int c2 = a01*b10;
int C = c1+c2;
 Console.WriteLine(c1);
 Console.WriteLine(c2);
 Console.WriteLine(C);

int[,] array3 = new int[2, 2];
array3[0,0] = ((a00*b00) + (a01*b10));
array3[0,1] = ((a00*b01) + (a01*b11));
array3[1,0] = ((a10*b00) + (a11*b10));
array3[1,1] = ((a10*b01) + (a11*b11));

for (int i = 0; i < array3.GetLength(0); i++)
{
    for (int j = 0; j < array3.GetLength(1) ; j++)
    {
        Console.Write(array3[i,j] + "\t");
    }
    Console.WriteLine();

}



