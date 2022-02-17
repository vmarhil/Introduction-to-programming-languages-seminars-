// Найти сумму чисел одномерного массива стоящих на нечетной позиции
Console.Clear();


int[] mass = new int[5]; 
int sumNeChet = 0;
for (int i = 0; i < mass.Length ; i++) 
{ 
    mass[i] = new Random().Next(0, 10); 
    Console.WriteLine(mass[i]); 
    Console.WriteLine();
    
    if (i % 2 == 1)    //(mass[i] % 2 == 1)
    {
        sumNeChet = sumNeChet + mass[i];
    }
 
} 
Console.Write("Сумма нечетных чисел " + sumNeChet);
