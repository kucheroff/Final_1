void printArray(string[] array)
{
    Console.Write("[");

    for (int i = 0; i<array.Length; i++)
    {
        if (i<array.Length-1) Console.Write($"\"{array[i]}\", ");
        else Console.Write($"\"{array[i]}\"");
    }
    Console.WriteLine("]");
}



Console.Clear();
Console.WriteLine("Исходный массив:");
string[] array= new string[4] {"hello","2","world",":-)"};
printArray(array);