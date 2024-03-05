string[] CreateArray()
{
    int size = GetPositiveInteger();
    string[] array = new string[size];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1} элемент массива: ");
        array[i] = Console.ReadLine()!;
    }
    return array;
}

int GetPositiveInteger()
{
    while (true)
    {
        Console.Write($"Задайте длину массива: ");
        if (int.TryParse(Console.ReadLine(), out int result))
        {
            if (result <= 0) Console.WriteLine("Число должно быть больше 0");
            else return result;
        }
        else Console.WriteLine("Не удалось распознать число, попробуйте еще раз");
    }
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"\"{array[i]}\"");
        if (i == array.Length - 1) break;
        Console.Write(", ");
    }
    Console.WriteLine($"]");
}

int GetCountOfShortElements(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    return count;
}

string[] CreateArrayFromArray(string[] initialArray)
{
    string[] resultArray = new string[GetCountOfShortElements(initialArray)];
    int count = 0;
    for (int i = 0; i < initialArray.Length; i++)
    {
        if (initialArray[i].Length <= 3)
        {
            resultArray[count] = initialArray[i];
            count++;
        }
    }
    return resultArray;
}


string[] initialArray = CreateArray();

Console.Write("Введенный массив: ");
PrintArray(initialArray);

Console.Write("Сформированный массив: ");
PrintArray(CreateArrayFromArray(initialArray));