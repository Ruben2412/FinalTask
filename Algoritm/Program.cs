/* ЗАДАЧА:
Написать программу, которая из имеющегося
массива строк формирует массив из строк, 
длина которых либо меньше либо равна 3 символа.
Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма.
При решение не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами.
*/

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

string InputText(string input)
{
    Console.Write(input);
    string output = Console.ReadLine();
    return output;
}

string[] CreateSizeArray(int size)
{
    string[] array = new string[size];

    for (int i = 0; i < size; i++)
    {
        Console.WriteLine();
        var element = InputText($"Input {i + 1} element: ");
        array[i] = element;

    }
    return array;
}

string[] ChangeCreatedArray(string[] array, int size)
{
    string[] massiv = new string[size];

    int length = 3;
    int j = 0;

    for (int i = 0; i < size; i++)
    {
        if (array[i].Length <= length)
        {
            massiv[j] = array[i];
            j++;
        }
    }
    return massiv;
}

string[] CutCreatedArray(string[] array, int size, int length)
{
    string[] massiv = new string[size];
    int j = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i].Length <= length)
        {
            massiv[j] = array[i];
            j++;
        }
    }
    return massiv;
}

void ShowArray(string[] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "; ");
        Console.WriteLine();
    }
}

void ShowThirdLetterArray(string[] array)
{
    Console.WriteLine();
    int length = 3;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= length)
        {
            Console.Write(array[i] + "; ");
            Console.WriteLine();
        }
    }
}

int number = InputNumbers("Enter the number of array elements: ");

string[] arrayString = CreateSizeArray(number);

Console.WriteLine();
Console.WriteLine("The first is the most boring option");

ShowArray(arrayString);
ShowThirdLetterArray(arrayString);

Console.WriteLine();
Console.WriteLine("The second option is more interesting");

ShowArray(arrayString);
string[] changedArrayString = ChangeCreatedArray(arrayString, number);
ShowThirdLetterArray(changedArrayString);


Console.WriteLine();
Console.WriteLine("The third option is where you can determine the number of elements in an array cell");

Console.WriteLine("Enter the number of elements in the array cell or press ENTER if 3 elements in the array cell are enough.: ");
int howLong;
ConsoleKeyInfo keyInfo = Console.ReadKey(true);
if (keyInfo.Key == ConsoleKey.Enter)
    howLong = 3;
else
    howLong = Convert.ToInt32(Console.ReadLine());

ShowArray(arrayString);
string[] cutArrayString = CutCreatedArray(arrayString, number, howLong);
ShowThirdLetterArray(cutArrayString);
