string[] fillToThree(string[] array)
{
    int count = 0;
    for (int i = 0; i<array.Length; i++) // Обнаруживаем размерность итогового массива
    {
        if(array[i].Length<=3) count++;
    }

    string[] new_array = new string[count]; // Делаем итоговй массив нужной длины
    count = 0;

    for (int i = 0; i < array.Length; i++)  // Заполняем итоговый массив нужными элементами
    {
        if(array[i].Length <=3 ) 
        {
            new_array[count] = array[i];
            count++;
        }
    }

    return new_array;
}

void printArray(string[] array)
{
    Console.Write("[");

    for (int i = 0; i<array.Length; i++)
    {
        if (i<array.Length-1) Console.Write($"\"{array[i]}\", "); // красивый вывод со скобками и кавычками
        else Console.Write($"\"{array[i]}\"");
    }
    Console.WriteLine("]");
}


// Тут жестко варианты трех входных данных из задания и решение...
Console.Clear();
Console.WriteLine("Исходный массив:");
string[] array= new string[4] {"hello","2","world",":-)"};
printArray(array);
Console.WriteLine("Массив с количеством символов не более трех:");
printArray(fillToThree(array));
Console.WriteLine();

Console.WriteLine("Исходный массив:");
array= new string[4] {"1234","1567","-2","computer science"};
printArray(array);
Console.WriteLine("Массив с количеством символов не более трех:");
printArray(fillToThree(array));
Console.WriteLine();

Console.WriteLine("Исходный массив:");
array= new string[3] {"Russia","Denmark","Kazan"};
printArray(array);
Console.WriteLine("Массив с количеством символов не более трех:");
printArray(fillToThree(array));

