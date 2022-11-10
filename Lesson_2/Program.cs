// Метод 1. Ничего не принимает и ничго не возращает
// void method_1()
// {
//     Console.WriteLine("Автор ...");
// }
//method_1();

// Метод 2. Принимает и ничего не возращает
// void method_2(string msg)
// {
//     Console.WriteLine(msg);
// }
//method_2(msg: "Текст сообщения");

// void method_21(string msg, int count)
// {
//     int i=0;
//     while(i<count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
//method_21("Текст", 4);
//method_21(count: 4, msg: "Новый текст");

//Метод 3. Не принимает и возращает
// int method_3()
// {
//     return DateTime.Now.Year;
// }
// int year = method_3();
// Console.WriteLine(year);

//Метод 4. Принимает и возращает
// string method_4(int count, string text)
// {
//     int i = 0;
//     string resoult = " "; //или вместо " " String.Empty
//     while (i < count)
//     {
//         resoult = resoult + text;
//         i++;
//     }
//     return resoult;
// }
// 
// Замена символов в тексте
// string text = "- я думаю, - сказал князь, улыбаясь, - что,"
//             + "если бы вас послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие прусского короля. "
//             + "Вы так красноречивы. Вы дадите мне чаю?";
//string s = qwerty
//           012345
//s[3] = r
// string Replace(string text, string change, char oldValue, char newValue)
// {
//     string resoult = $"{change}";
//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if(text[i] == oldValue) resoult = resoult + $"{newValue}";
//         else resoult = resoult + $"{text[i]}";
//     }
//     return resoult;
// }
// string newText = Replace(text, "Замена пробела на знак | : ", ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'с', 'С');
// Console.WriteLine(newText);

//Сортировка массива
int[] arr = {1,5,4,3,2,6,7,1,1};
void printArray (int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void selectionSort(int[] array)
{
for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i+1; j < array.Length; j++)    
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
printArray(arr);
selectionSort(arr);
printArray(arr);
