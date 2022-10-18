Start:
Console.Clear();
Console.WriteLine("1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");
Console.WriteLine();
Console.WriteLine("2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");
Console.WriteLine();
Console.WriteLine("3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).");
Console.WriteLine();
Console.WriteLine("4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");
Console.WriteLine();
Console.WriteLine("5. Выход из программы.");
Console.WriteLine();
Console.Write("Введите номер задачи: ");

int numberIssue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
if (numberIssue<=0||numberIssue>5)
{
    goto Start;
}
if (numberIssue == 5)
{
    Environment.Exit(0);
}

if (numberIssue == 1)
{
    Console.Write("Введите 1 число: ");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите 2 число: ");
    int number2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    if (number1 > number2)
    {
        Console.Write(number1);
        Console.Write(" больше ");
        Console.WriteLine(number2);  
    }
    if (number1 < number2)
    {
        Console.Write(number1);
        Console.Write(" меньше ");
        Console.WriteLine(number2); 
    }
    if (number1 == number2)
    {
        Console.WriteLine("Числа равны");
    }

    Console.WriteLine();
    Console.Write("Для продолжения нажмите любую клавишу.");
    Console.ReadKey();
    goto Start;

}



if (numberIssue == 2)
{
    int maxNumber = 0;
    int i = 0;
    while (i<3)
    {
        Console.Write("Введите ");
        Console.Write (i+1);
        Console.Write (" число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > maxNumber)
        {
            maxNumber = number;
        }
        i++;
    }
    Console.WriteLine();
    Console.Write("Максимальное число ");
    Console.WriteLine (maxNumber);

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
    if (number %2 == 0)
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
if (numberIssue == 4)
{
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    int i = 2;
    Console.Write("Четные числа: ");
    while (i <= number)
    {
        Console.Write(i);
        Console.Write(" ");
        i+=2;
    }

    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Для продолжения нажмите любую клавишу.");
    Console.ReadKey();
    goto Start;

}