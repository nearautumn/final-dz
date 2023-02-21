Console.Clear();

string[] textInitial = GetStringArrayFromUser(); // создание массива из строк

PrintStringArray(textInitial); // вывод начального массива

int textFinalLength = GetTextFinalLength(textInitial); // определение размера конечного массива

string[] textFinal = GetTextLessThanThree(textInitial, textFinalLength); // определяем элементы размером менее 3 символов и записываем в массив

Console.Write(" -> ");
PrintStringArray(textFinal); // вывод конечного массива

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


int GetTextFinalLength(string[] stringArray) 
{
    int result = 0;
    for (int i = 0; i < stringArray.Length; i++) 
    {
        int count = 0;
        foreach (char symbol in stringArray[i])
        {
            if (symbol > 0) count++;
        }
        if (count <= 3) result++;
    }
    return result;
} 

string[] GetTextLessThanThree(string[] stringArray, int resultLength) 
{
    string[] resultArray = new string[resultLength];
    int j = 0;
    for (int i = 0; i < stringArray.Length; i++) 
    {
        int count = 0;
        foreach (char symbol in stringArray[i])
        {
            if (symbol > 0) count++;
        }
        if (count <= 3) 
        {
            resultArray[j] = stringArray[i];
            j++;
        }
    }
    return resultArray;
} 