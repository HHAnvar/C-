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
    Console.Write("Введите пятизначное число: ");
    string number = Console.ReadLine();
    int truNumber = Convert.ToInt32(number);
    if (truNumber < 10000 || truNumber > 99999)
    {
        Console.WriteLine();
        Console.WriteLine($"Число  {number}  не пятизначное.");
        Console.WriteLine();
        goto issue1;
    }
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine();
        Console.WriteLine($"Число  {number}  - полиндром");
        Console.WriteLine();
        Console.WriteLine("Для продолжения нажмите любую клавишу.");
        Console.ReadKey();
        Console.WriteLine();
        goto Start;
    }
    Console.WriteLine();
    Console.WriteLine($"Число  {number}  - не полиндром");
    Console.WriteLine();
    Console.Write("Для продолжения нажмите любую клавишу.");
    Console.ReadKey();
    goto Start;
}

if (numberIssue == 2)
{
    Console.Write("Введите x1: ");
    int x1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите y1: ");
    int y1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите z1: ");
    int z1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите x2: ");
    int x2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите y2: ");
    int y2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите z2: ");
    int z2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine();
    double d = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));
    Console.WriteLine($"Расстояние между точками {d}");
    Console.WriteLine();
    Console.Write("Для продолжения нажмите любую клавишу.");
    Console.ReadKey();
    goto Start;

}
if (numberIssue == 3)
{
    Console.Write("Введите число: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    for (int i = 1; i <= n; i++)
    {
        Console.WriteLine($"{i} в кубе = {(int)Math.Pow(i, 3)}");
    }
    Console.WriteLine();
    Console.WriteLine("Для продолжения нажмите любую клавишу.");
    Console.ReadKey();
    goto Start;
}
