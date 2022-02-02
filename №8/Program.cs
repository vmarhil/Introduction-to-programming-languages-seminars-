// Показать четные числа от 1 до N
Console.Clear();
int[] Array  = {1,2,3,6,5,200,88,48,15};                             
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