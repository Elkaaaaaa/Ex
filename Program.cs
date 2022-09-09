//Методы 
void PrintArray(string[] array)
{
    Console.Write("{");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write("\b\b}");
    Console.WriteLine();
}

//Задача
Console.WriteLine("Введите количество элементов массива:");
int size = Convert.ToInt32(Console.ReadLine());
string[] firstArray = new string[size];
Console.WriteLine("Введите элементы массива:");
for (int i = 0; i < size; i++)
{
    Console.Write($"[{i}]: ");
    firstArray[i] = Console.ReadLine();
}
string[] lastArray = new string[size];
int k = 0;
Console.WriteLine("Имеющийся массив:");
PrintArray(firstArray);
for (int i = 0; i < size; i++)
{
    if (firstArray[i].Length <= 3)
    {
        lastArray[k] = firstArray[i];
        k++;
    }
}
Array.Resize(ref lastArray, k);
Console.WriteLine("Полученный массив:");
PrintArray(lastArray);