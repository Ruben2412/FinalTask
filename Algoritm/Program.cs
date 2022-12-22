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

int CorrectNumb(string input)
{
    Console.Write(input);
    int output;
    ConsoleKeyInfo keyInfo = Console.ReadKey(true);
    if (keyInfo.Key == ConsoleKey.Enter)
    {
        output = 3;
        return output;
    }
    else
    {
        output = Convert.ToInt32(Console.ReadLine());
        return output;
    }
}

string InputText(string input)
{
    Console.Write(input);
    string output = Console.ReadLine();
    return output;
}

string[] CreateArray()
{
    string result = InputText("Enter the values separated by a space: ");
    return result.Split(" ");
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

string[] ChangeCreatedArray(string[] array)
{
    string[] massiv = new string[array.Length];

    int length = 3;
    int j = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= length)
        {
            massiv[j] = array[i];
            j++;
        }
    }
    return massiv;
}

string[] CutCreatedArray(string[] array, int length)
{
    string[] massiv = new string[array.Length];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
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
        Console.WriteLine(array[i] + ";");
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
            Console.WriteLine(array[i] + ";");
        }
    }
}


//Массивы с заданным размером
int number = InputNumbers("Enter the number of array elements: ");
string[] arrayString = CreateSizeArray(number);

//Первый вариант
Console.WriteLine();
Console.WriteLine("1.1");
ShowArray(arrayString);
ShowThirdLetterArray(arrayString);

//Второй вариант
Console.WriteLine();
Console.WriteLine("1.2");
ShowArray(arrayString);
string[] changedArrayString = ChangeCreatedArray(arrayString);
ShowThirdLetterArray(changedArrayString);

//Третий вариант
Console.WriteLine();
Console.WriteLine("1.3");
int leng = CorrectNumb("Enter the number of elements in the array cell or press ENTER if 3 elements in the array cell are enough: ");

ShowArray(arrayString);
string[] cutArrayString = CutCreatedArray(arrayString, leng);
ShowArray(cutArrayString);

//Безразмерные массивы
Console.WriteLine();
string[] splitArray = CreateArray();
//Первый вариант
Console.WriteLine();
Console.WriteLine("2.1");
ShowArray(splitArray);
ShowThirdLetterArray(splitArray);
//Второй вариант
Console.WriteLine();
Console.WriteLine("2.2");
ShowArray(splitArray);
string [] changedSplitArray = ChangeCreatedArray(splitArray);
ShowArray(changedSplitArray);
// Третий вариант
Console.WriteLine();
Console.WriteLine("2.3");
int lonG = CorrectNumb("Enter the number of elements in the array cell or press ENTER if 3 elements in the array cell are enough: ");
ShowArray(splitArray);
string[] cutSplitArray = CutCreatedArray(splitArray, lonG);
ShowArray(cutSplitArray);