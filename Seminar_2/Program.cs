Start:
Console.Clear();
Console.WriteLine("1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
Console.WriteLine();
Console.WriteLine("2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
Console.WriteLine();
Console.WriteLine("3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
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
    Console.WriteLine();
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number<100)
    {
    Console.WriteLine();
    Console.Write("В числе "+number+" третьей цифры нет.");
    Console.WriteLine();
    goto issue2;
    }
    int i = 0;
    while (i<2)
    {
        if (number < 1000)
        {   
            break;
        }
        number = number/10;
    }
    Console.WriteLine();
    Console.WriteLine("Третья цифра в числе " + number + ": " + number % 10);
    Console.WriteLine();

    Console.WriteLine();
    Console.WriteLine("Для продолжения нажмите любую клавишу.");
    Console.ReadKey();
    goto Start;

}

if (numberIssue == 3)
{
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    if (number % 2 == 0)
    {
        Console.Write("Число ");
        Console.Write(number);
        Console.WriteLine(" четное");
    }
    else
    {
        Console.Write("Число ");
        Console.Write(number);
        Console.WriteLine(" нечетное");
    }

    Console.WriteLine();
    Console.WriteLine("Для продолжения нажмите любую клавишу.");
    Console.ReadKey();
    goto Start;

}
