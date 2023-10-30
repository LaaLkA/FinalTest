// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

int TakeNumber(string message)
{
    Console.WriteLine($"Enter {message}");
    if (int.TryParse(Console.ReadLine(), out int Number)) return Number;
    else
    {
        Console.WriteLine("Введите целое неотрицательное число");
        return TakeNumber(message);
    }
}
string[] DoArray2(string[] array1)
{
    int num = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3) num++;
    }
    
    int count = 0;
    string[] array2 = new string[num];
    for (int j = 0; j < array1.Length; j++)
    {
        if (array1[j].Length <= 3)
        {
            array2[count] = array1[j];
            count++;
        }
    }
    return array2;
}
void PrintArray(string[] array, string message)
{
    Console.WriteLine($"{message} массив");
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (i + 1 < array.Length) Console.Write(", ");
    }
    Console.Write("]");
    Console.WriteLine();
}
string[] TakeArray1(string[] array)
{
    string temp;
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1}е значение начального массива");
        temp = Console.ReadLine() ?? "";
        array[i] = temp;
    }
    return array;
}

Console.Clear();

string[] array1 = new string[TakeNumber("длину начального массива")];
TakeArray1(array1);
PrintArray(array1, "Исходный");
PrintArray(DoArray2(array1), "Полученный из исходного");