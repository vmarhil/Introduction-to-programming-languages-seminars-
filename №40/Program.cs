// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
// Вариант 1
/*Console.Clear();

int[] mass = new int[5];
for (int i = 0; i < mass.Length ; i++)
{
    mass[i] = new Random().Next(1, 199); 
    Console.Write(mass[i]);
    Console.WriteLine();
}
int max = 0;
int min = 200;
if (mass[0] > max) max = mass[0];
if (mass[1] > max) max = mass[1];
if (mass[2] > max) max = mass[2];
if (mass[3] > max) max = mass[3];
if (mass[4] > max) max = mass[4];
if (mass[0] < min) min = mass[0];
if (mass[1] < min) min = mass[1];
if (mass[2] < min) min = mass[2];
if (mass[3] < min) min = mass[3];
if (mass[4] < min) min = mass[4];
Console.Write("max = ");
Console.WriteLine(max);
Console.Write("min = ");
Console.WriteLine(min); 
Console.Write($"Разница между максимальным и минимальным элементом max-min = {max-min}  ");*/

Console.Clear();
int[] mass = new int[10]; 
 
for (int i = 0; i < mass.Length; i++) 
{ 
    mass[i] = new Random().Next(1, 99); 
    Console.Write(mass[i] + " "); 
} 
Console.WriteLine(); 

int max = mass[0];
int min = mass[0];
for (int i = 1; i < 10; i++)
{
    if (mass[i] < min) min = mass[i];
    if (mass[i] > max) max = mass[i];
}
            
Console.WriteLine("Разница между максимальным и минимальным = {0}", max - min);


