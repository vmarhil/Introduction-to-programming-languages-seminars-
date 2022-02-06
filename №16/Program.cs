// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
//string array = ["пн", "вт", "ср", "чт", "пт", "сб", "вс"];

Console.Clear();
Console.WriteLine("введите чилсло: от 1 до 7 ");
string n = Console.ReadLine();
Console.WriteLine("Число недели:" + n);
if (n == "1")
{
    Console.WriteLine("Пн: Рабочий день недели");
}
else if (n == "2")
{
    Console.WriteLine("Вт: Рабочий день недели");
}
else if (n == "3")
{
    Console.WriteLine("Ср: Рабочий день недели");
}
else if (n == "4")
{
    Console.WriteLine("Чт: Рабочий день недели");
}
else if (n == "5")
{
    Console.WriteLine("Пт: Рабочий день недели");
}
else if (n == "6")
{
    Console.WriteLine("Сб: Выходной");
}
else if (n == "7")
{
    Console.WriteLine("Вс: Выходной");
}
else     Console.WriteLine("Не верная команда!!");
