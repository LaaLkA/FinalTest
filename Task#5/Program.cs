// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

int TakeNumber(string message)
{
    System.Console.WriteLine($"Enter {message}");
    if (int.TryParse(Console.ReadLine(), out int Number)) return Number;
    else
    {
        Console.WriteLine("Введите целое неотрицательное число");
        return TakeNumber(message);
    }
}
void DoArray2(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (i < array2.Length)
        {
            array2[count] = array1[i];
            count++;
        }
    }
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
string[] TakeArray1(int number, string[] array)
{
    string temp;
    for (int i = 0; i < number; i++)
    {
        Console.WriteLine($"Введите {i + 1}е значение начального массива");
        temp = Console.ReadLine() ?? "";
        array[i] = temp;
    }
    return array;
}

Console.Clear();

Random rand = new Random();

int number = TakeNumber("длину начального массива");
string[] array1 = new string[number];
string[] array2 = new string[rand.Next(1, 4)];

TakeArray1(number, array1);
DoArray2(array1, array2);
PrintArray(array1, "Исходный");
PrintArray(array2, "Полученный из исходного");