Start:
void Continue()
{
    Console.WriteLine();
    Console.Write("Для продолжения нажмите любую клавишу.");
    Console.ReadKey();

}

void FillArray(int[,] matr)
{
        for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(10);
        }
    }
    Console.WriteLine();

}

void PrintArray(int[,] matr)
{
        for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i,j] + "\t");
        }
        Console.WriteLine();
    }
    

}

Console.Clear();
Console.WriteLine(
    "1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами."
);
Console.WriteLine();
Console.WriteLine(
    "2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет."
);
Console.WriteLine();
Console.WriteLine(
    "3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце."
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
    Console.Write("Введите количество строк в массиве: ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.Write("Введите количество столбцов в массиве: ");
    int column = Convert.ToInt32(Console.ReadLine());
    int[,] matrix = new int[row,column];

    FillArray(matrix);
    PrintArray(matrix);
    Continue();
    goto Start;
}

if (numberIssue == 2)

{
    
    Console.Write("Введите номер строки элемента в массиве: ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите номер столбца элемента в массиве: ");
    int col = Convert.ToInt32(Console.ReadLine());
    int[,] matrix = new int[5,6];
    
    FillArray(matrix);
    PrintArray(matrix);
    Console.WriteLine();

    if (row>matrix.GetLength(0) || col>matrix.GetLength(1))
    {
        Console.WriteLine($"Элемента на позиции ({row}:{col}) нет");
    }
    else Console.WriteLine($"Элемент на позиции ({row}:{col}): {matrix[row,col]}");
        
    Continue();
    goto Start;

}

if (numberIssue == 3)

{
    
    int[,] matrix = new int[5,6];
    
    FillArray(matrix);
    PrintArray(matrix);
    Console.WriteLine();
    Console.WriteLine("Среднее арифметическое элементов в каждом столбце:");
    Console.WriteLine();

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        }
        Console.Write($"{ sum / matrix.GetLength(0)} \t");
    }      
    Console.WriteLine();
    Continue();
    goto Start;

}


