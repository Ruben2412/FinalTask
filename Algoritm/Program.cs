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

string [] CreateSizeArray(int size)
{
    string[] array = new string[size];

    for (int i = 0; i < size; i++)
    {
        var element = InputText($"Input {i + 1} element: ");
        array[i] = element;
        
    }
    return array;
}

void ShowArray(string [] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + "; ");
    Console.WriteLine();
}


int number = InputNumbers("Imput count of elements ");

string[] arrayString = CreateSizeArray(number);

ShowArray(arrayString);
