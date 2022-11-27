Start:

void Continue()
{
    Console.WriteLine();
    Console.Write("Для продолжения нажмите любую клавишу.");
    Console.ReadKey();

}

Console.Clear();
Console.WriteLine(
    "1. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии."
);
Console.WriteLine();
Console.WriteLine(
    "2. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N."
);
Console.WriteLine();
Console.WriteLine(
    "3. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n."
);

Console.WriteLine();
Console.WriteLine("4. Выход из программы.");
Console.WriteLine();
Console.Write("Введите номер задачи: ");

int numberIssue = Convert.ToInt32(Console.ReadLine());
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
    Console.WriteLine();
    Console.Write("Введите число ,больше 0: ");
    int n = Convert.ToInt32(Console.ReadLine());

    string PrintNumber(int start,int end)
    {
        if(end == start)
        {
            return start.ToString();
        }
        if (end == 0)
        {
            return "Введите корректное число.";
        }

        return(end+" "+PrintNumber(start,end-1));
}
    Console.WriteLine(PrintNumber(1,n));
    Continue();
    goto Start;
}

if (numberIssue == 2)

{
    Console.WriteLine();
    Console.Write("Введите начальное число: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.Write("Введите конечное число: ");
    int n = Convert.ToInt32(Console.ReadLine());

    int SumNumber(int start,int end)
    {
        if(end == start)
        {
            return start;
        }

        return(start+SumNumber(start+1,end));
    }
    Console.WriteLine(SumNumber(m,n));
    Continue();
    goto Start;
}

if (numberIssue == 3)
{
    Console.WriteLine();
    Console.Write("Введите число: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.Write("Введите число: ");
    int n = Convert.ToInt32(Console.ReadLine());

    int Akkerman(int n, int m)
    {
        if (m == 0)
        {
            return n + 1;
        }
        if ((m != 0) && (n == 0))
        {
            return Akkerman(m - 1, 1);
        }
        return Akkerman(m - 1, Akkerman(m, n - 1));
}
Console.WriteLine(Akkerman(m,n));
}

