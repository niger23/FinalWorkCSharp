string[] FillArray ()
{
    string[] startArray = new string[0];
    for (int i = 0; ; i++)
    {
        string? value = string.Empty;
        Console.WriteLine("Оставьте поле пустым, если хотите закончить ввод!");
        Console.Write($"Введите {i} элемент массива: ");
        value = Console.ReadLine();
        if (!String.IsNullOrEmpty(value))
        {
            Array.Resize(ref startArray,startArray.Length +1);
            startArray[i] = value;
        }
        else break;
    }
    return startArray;

}

void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write(array[array.Length - 1]);
    Console.WriteLine();
}

string[] ElementLess3 (string[] array)
{
    string[] resultArray = new string [0];
    int current = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            Array.Resize(ref resultArray,resultArray.Length +1);
            resultArray[current] = array[i];
            current++;
        }
    }
    return resultArray;
}

string[] newArray = FillArray();
ShowArray(newArray);
Console.WriteLine();
string[] result = ElementLess3(newArray);
Console.WriteLine("Массив из элементов менее или равно: 3 символов!");
ShowArray(result);