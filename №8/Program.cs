// Показать четные числа от 1 до N
Console.Clear();
int[] Array  = {1,2,3,4,5,78,86,98,188};                             
int n=Array.Length;
int index=0;
while(index<n)
{
    if(Array[index]%2==0)
    {
        Console.WriteLine(Array[index]);  
    }
    index++;
}