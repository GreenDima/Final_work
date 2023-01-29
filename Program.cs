string [] Array(int size)
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

Console.Write("Введите размер массива:");
int size = Convert.ToInt32(Console.ReadLine());
string [] array = Array(size);
int newsize = NewSizeArray(array);