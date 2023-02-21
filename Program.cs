Console.Clear();

string[] text = GetStringArrayFromUser(); // создание массива из строк

PrintStringArray(text); // вывод созданного массива

PrintTextLessThanThree(text); // определяем элементы размером менее 3 символов и выводим

/////////////////////////////////////////////////////////////////////////////////////////////
string[] GetStringArrayFromUser() 
{
    Console.Write("Введите длину массива: ");
    int length = int.Parse(Console.ReadLine() ?? "");

    Console.WriteLine("Введите содержимое массива:");
    string[] stringArray = new string[length];
    for (int i = 0; i < length; i++) 
    {
        stringArray[i] = Console.ReadLine() ?? "";
    }

    return stringArray;
}

void PrintStringArray(string[] stringArray) 
{
    Console.Write("[");
    for (int i = 0; i < stringArray.Length; i++) 
    {
        Console.Write($"'{stringArray[i]}' ");
    }
    Console.Write("]");
}


void PrintTextLessThanThree(string[] stringArray) 
{
    Console.Write(" -> [");
    for (int i = 0; i < stringArray.Length; i++) 
    {
        int count = 0;
        foreach (char symbol in stringArray[i])
        {
            if (symbol > 0) count++;
        }
        if (count <= 3) Console.Write($"'{stringArray[i]}' ");
    }
    Console.Write("]");
} 