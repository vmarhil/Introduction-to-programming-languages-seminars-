// Подсчитать сумму цифр в числе

Console.Clear();
Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());
int s = 0;
while (n > 0)
{
    s = s + n % 10;
    n = n / 10;
    
}
Console.WriteLine(s); 
