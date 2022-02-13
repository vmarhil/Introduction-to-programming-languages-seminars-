// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
Console.Clear();
int [] array = {1,0,0,1,1,0,1,0};
int c = 0;
while (c != (array.Length))
{
    Console.Write(array[c] + "\t");
    c++;
}
