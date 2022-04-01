Console.Clear();

string[] myArray = new string[5] {"432", "43", "Hoho", "war", ":=O"};
string[] Array2 = new string[myArray.Length];
void M1(string[] myArray, string[] Array2)
{
    int count = 0;
    for (int i = 0; i < myArray.Length; i++)
    {
    if(myArray[i].Length <= 3)
        {
        Array2[count] = myArray[i];
        count++;
        }
    }
}
void M2(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
M1(myArray, Array2);
M2(Array2);

