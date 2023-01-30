int CheckingInput()
{
    string? number = Console.ReadLine();
    int size;
    if(int.TryParse(number, out size) && size > 0) return size;
    else
    {
        Console.Clear();
        Console.Write("Ошибка ввода. Введите положительное число: ");
        return CheckingInput();
    }
}
string [] CreatArray(int size)
{
    string [] arr = new string[size];
    Console.WriteLine($"Введите {size} слов(а): ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{i + 1} слово: ");
        arr[i] = Console.ReadLine();
        Console.Clear();
    }
    return arr;
}

int NewSizeArray(string [] array)
{
    int size = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length < 4) size++;
    }
    return size;
}

string [] CreatNewArray(int newsize, string [] array)
{
    string [] newarr = new string[newsize];
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if(array[i].Length < 4)
        {
            newarr[j] = array[i];
            j++;
        }
    }
    return newarr;
}

void PrintArray(string [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}; ");
    }
}

Console.Write("Введите размер массива: ");
int size = CheckingInput();
Console.Clear();
string [] array = CreatArray(size);
int newsize = NewSizeArray(array);
string [] newarray = CreatNewArray(newsize, array);
PrintArray(array);
Console.WriteLine();
PrintArray(newarray);