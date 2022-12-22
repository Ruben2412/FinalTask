/* ЗАДАЧА:
Написать программу, которая из имеющегося
массива строк формирует массив из строк, 
длина которых либо меньше либо равна 3 символа.
Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма.
При решение не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами.
*/

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

string[] splitArray = CreateArray();

string [] changedSplitArray = ChangeCreatedArray(splitArray);

Console.WriteLine($"[{string.Join(", ", splitArray)}] -> [{string.Join(", ", changedSplitArray)}]");