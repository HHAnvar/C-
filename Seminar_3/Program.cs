Start:
Console.Clear();
Console.WriteLine(
    "1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом."
);
Console.WriteLine();
Console.WriteLine(
    "2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве."
);
Console.WriteLine();
Console.WriteLine(
    "3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N."
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
    Console.Write("Введите трехзначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number < 100 || number > 1000)
    {
        Console.WriteLine();
        Console.WriteLine("Не верное число.");
        Console.WriteLine();
        goto issue1;
    }
    Console.WriteLine();
    Console.WriteLine("Вторая цифра в числе " + number + ": " + number / 10 % 10);

    Console.WriteLine();
    Console.Write("Для продолжения нажмите любую клавишу.");
    Console.ReadKey();
    goto Start;
}

if (numberIssue == 2)
{
    issue2:
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    if (number < 100)
    {
        Console.Write("В числе " + number + " третьей цифры нет.");
        goto issue2;
        Console.WriteLine();
    }
    int i = 0;
    int number1 = number;
    while (i < 2)
    {
        if (number1 < 1000)
        {
            break;
        }
        number1 = number1 / 10;
    }
    Console.WriteLine("Третья цифра в числе " + number + ": " + number1 % 10);
    Console.WriteLine();
    Console.WriteLine("Для продолжения нажмите любую клавишу.");
    Console.ReadKey();
    goto Start;
}

if (numberIssue == 3)
{
    issue3:
    Console.Write("Введите цифру c 1 до 7, обозначающую день недели: ");
    int number = Convert.ToInt32(Console.ReadLine());
    
    if (number < 1 || number > 7)
    {
        Console.WriteLine();
        Console.WriteLine("Неверное число. ");
        Console.WriteLine();
        goto issue3;
    }
    
    if (number == 6 || number == 7)
    {
        Console.WriteLine();
        Console.WriteLine("Это выходной день.");
    }
    else 
    {
        Console.WriteLine();
        Console.WriteLine("Это не выходной день.");
    }

    Console.WriteLine();
    Console.WriteLine("Для продолжения нажмите любую клавишу.");
    Console.ReadKey();
    goto Start;
}
