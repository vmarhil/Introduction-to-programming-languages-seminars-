// Показать натуральные числа от N до 1, N задано

Console.Clear();
Console.WriteLine("Введите число: ");
int number2 = int.Parse(Console.ReadLine());
int number1 = 1;

string number3 = Number(number1, number2);
Console.Write($"{number3} ");
string Number(int num1, int num2)  
{
    if (num1 <= num2) 
        return ($"{num2} {Number( num1, num2 - 1)}");       

    else return String.Empty;
}