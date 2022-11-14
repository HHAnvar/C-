Start:
Console.Clear();
Console.WriteLine(
    "1. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве."
);
Console.WriteLine();
Console.WriteLine(
    "2. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях."
);
Console.WriteLine();
Console.WriteLine(
    "3. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива."
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
    int[] array = new int[10];
    int evenNum = 0;
    Console.Write("Массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,999);
        Console.Write(array[i] +", ");
        if (array[i] %2 == 0)
        {
            evenNum += 1;
        }
    }
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Количество положительных чисел в массиве: " + evenNum);

    Console.WriteLine();
    Console.Write("Для продолжения нажмите любую клавишу.");
    Console.ReadKey();
    goto Start;
}

if (numberIssue == 2)
{
    int[] array = new int[10];
    int sum = 0;
    Console.Write("Массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(10);
        Console.Write(array[i] +", ");
    }
    for (int i = 0; i < array.Length; i+=2)
    {
        sum+=array[i];
    }
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Сумма элементов, стоящих на нечетных позициях: " + sum);

    Console.WriteLine();
    Console.Write("Для продолжения нажмите любую клавишу.");
    Console.ReadKey();
    goto Start;

}
if (numberIssue == 3)
{

    int[] array = new int[10];
    Console.Write("Массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100);
        Console.Write(array[i] +", ");
    }

    int minNum = array[0];
    int maxNum = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < minNum)
        {
            minNum = array[i];
        }
        if(array[i] > maxNum)
        {
            maxNum = array[i];
        }
    }
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine($"{maxNum} - {minNum} = {maxNum-minNum}");

    Console.WriteLine();
    Console.WriteLine("Для продолжения нажмите любую клавишу.");
    Console.ReadKey();
    goto Start;
}


