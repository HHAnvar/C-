Start:
Console.Clear();
Console.WriteLine(
    "1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B."
);
Console.WriteLine();
Console.WriteLine(
    "2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе."
);
Console.WriteLine();
Console.WriteLine(
    "3. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран."
);
Console.WriteLine();
Console.WriteLine("4. Выход из программы.");
Console.WriteLine();
Console.Write("Введите номер задачи: ");

int numberIssue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
if (numberIssue <= 0 || numberIssue > 4)
{
    goto Start;
}
if (numberIssue == 4)
{
    Environment.Exit(0);
}

if (numberIssue == 1)
{
    issue1:
    Console.Write("Введите число A: ");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число B: ");
    int number2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine();
    Console.WriteLine(number1 + " в степени " + number2 + " равно " + Math.Pow(number1, number2));
    Console.WriteLine();
    Console.Write("Для продолжения нажмите любую клавишу.");
    Console.ReadKey();
    goto Start;
}

if (numberIssue == 2)
{
    Console.Write("Введите число: ");
    string number = Console.ReadLine();
    int length = number.Length;
    int sum = 0;
    for (int i = 0; i < length; i++)
    {
        sum = sum + int.Parse(number[i].ToString());
    }

    Console.WriteLine();
    Console.WriteLine("Сумма цифр числа " + number + ": " + sum);



    Console.WriteLine();
    Console.Write("Для продолжения нажмите любую клавишу.");
    Console.ReadKey();
    goto Start;

}
if (numberIssue == 3)
{
    issue3:

    int[] getArray (int size)
    {
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.Write("Введите число: ");
            array[i] = Convert.ToInt32(Console.ReadLine());

        }
        return array;
    }
    Console.WriteLine(String.Join(",",getArray(8)));


    Console.WriteLine();
    Console.WriteLine("Для продолжения нажмите любую клавишу.");
    Console.ReadKey();
    goto Start;
}
