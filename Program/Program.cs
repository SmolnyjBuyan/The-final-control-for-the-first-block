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
    while(true)
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
    Console.Write("Введеный массив: [");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"\"{array[i]}\", ");
    }
    Console.WriteLine($"\"{array[array.Length - 1]}\"]");
}

PrintArray(CreateArray());