string[] textInitial = GetStringArrayFromUser(); // создание массива из строк

//string[] textFinal = GetTextLessThanThree(textInitial); // определяем элементы размером менее 3 символов и записвываем в новый массив

//PrintArrays(textInitial, textFinal); // выводим в консоль первоначальный массив и конечный

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