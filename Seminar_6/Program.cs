Start:
Console.Clear();
Console.WriteLine(
    "1. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь."
);
Console.WriteLine();
Console.WriteLine(
    "2. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем."
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
if (numberIssue == 3)
{
    Environment.Exit(0);
}

if (numberIssue == 1)
{
    Console.Write("Введите количество чисел:");

    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    int[] array = new int[m];
    int posNum = 0;
    Console.WriteLine("Введите числа: ");
    for (int i = 0; i < m; i++)
    {
    array[i] = Convert.ToInt32(Console.ReadLine());

        if (array[i] > 0)
        {
            posNum ++;
        }
    }
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Количество чисел ,больше 0: " + posNum);

    Console.WriteLine();
    Console.Write("Для продолжения нажмите любую клавишу.");
    Console.ReadKey();
    goto Start;
}

if (numberIssue == 2)

{
    
    Console.Write("Введите k1: ");
    int k1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите b1: ");
    int b1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите k2: ");
    int k2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите b2: ");
    int b2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    double x = 0;
    double y = 0;

    if (k1 == k2 && b1 != b2)
    {
        Console.WriteLine("Прямые параллельны и не имеют точек пересечения.");
        
        Console.WriteLine();
        Console.WriteLine("Для продолжения нажмите любую клавишу.");
        Console.ReadKey();

        goto Start;

    }
    if (k1 == k2 && k1 * b2 == k2 * b1 && b1 == b2)
    {
        Console.WriteLine("Прямые совпадают и имеют бесконечное количество решений.");

        Console.WriteLine();
        Console.WriteLine("Для продолжения нажмите любую клавишу.");
        Console.ReadKey();

        goto Start;

    }
    else
    x = (b2 - b1)/(k1 - k2);
    y = ((b2*k1) - (b1*k2))/(k1-k2);

    Console.WriteLine("Точка пересечения прямых: " + "(" + x + ";" + y + ")");

    Console.WriteLine();
    Console.Write("Для продолжения нажмите любую клавишу.");
    Console.ReadKey();
    goto Start;

}

