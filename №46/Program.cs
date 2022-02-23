/* Написать программу масштабирования фигуры
Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
например: "(0,0) (2,0) (2,2) (0,2)"
коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
В результате показать координаты, которые получатся.
при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"*/
Console.Clear();
string valueStr = "(0,0) (2,0) (2,2) (0,2)";
Console.WriteLine("Введите множитель:");
int k = int.Parse(Console.ReadLine());
valueStr = valueStr.Replace("(", "").Replace(")", "").Replace(",", " ");
string[] arrayStr = valueStr.Split(" ");
string result = string.Empty;
Console.WriteLine();
for (int i = 0; i < arrayStr.Length - 1; i = i + 2)
{
    int x = k * int.Parse(arrayStr[i]);
    int y = k * int.Parse(arrayStr[i + 1]);
    result = result + $"({x}, {y}) ";
}
Console.WriteLine("=============================");
Console.WriteLine(result);

