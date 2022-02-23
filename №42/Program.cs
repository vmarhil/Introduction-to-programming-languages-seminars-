// Определить сколько чисел больше 0 введено с клавиатуры

Console.Clear();
int j = 0;
Console.Write("Введите колличество элементов: ");
int n = int.Parse(Console.ReadLine());
int[] myArray = new int[n]; // 
for (int i = 0; i < myArray.Length; i++)
{
    Console.Write($"Введите элемент по индексом {i}: ");
    myArray[i] = int.Parse(Console.ReadLine()); ;
}
for (int i = 0; i < myArray.Length; i++)
{
    
    if (myArray[i] > 0)
    {
        j++;
    }


}
Console.WriteLine("Количество положительных чисел: ");
Console.WriteLine(j);