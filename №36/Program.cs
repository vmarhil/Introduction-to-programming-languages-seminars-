// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
Console.Clear();

int[] mass = new int[7]; 
int nechet = 0;
int chet = 0;
for (int i = 0; i < mass.Length ; i++) 
{ 
    mass[i] = new Random().Next(100, 999); 
    Console.WriteLine();
    Console.Write(mass[i]); 
    Console.WriteLine();
    if (mass[i] % 2==1)
{
    
    nechet ++;
    Console.WriteLine($"число нечетное {mass[i]}" );
    
}
    else 
{
    chet ++;
    Console.WriteLine($"число четное {mass[i]}");
} 
}
Console.WriteLine();
Console.WriteLine($" не четно число встретилась {nechet} раз" + "\t" );
Console.WriteLine($" четно  число встретилась {chet} раз" + "\t" );