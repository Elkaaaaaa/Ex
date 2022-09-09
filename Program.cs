//Методы 
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
    Console.WriteLine();
}

//Задача
string[] firstArray = { "ada", "asdas", "as", "asdas", "asd" };
string[] lastArray = new string[firstArray.Length];
int k = 0;
Console.WriteLine("Имеющийся массив:");
PrintArray(firstArray);
for (int i = 0; i < firstArray.Length; i++)
{
    if (firstArray[i].Length <= 3)
    {
        lastArray[k] = firstArray[i];
        k++;
    }
}
Console.WriteLine("Полученный массив:");
PrintArray(lastArray);