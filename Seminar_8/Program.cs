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
            matr[i,j] = new Random().Next(20);
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
    "1. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива."
);
Console.WriteLine();
Console.WriteLine(
    "2. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов."
);
Console.WriteLine();
Console.WriteLine(
    "3. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц."
);

Console.WriteLine();
Console.WriteLine(
    "4. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента."
);

Console.WriteLine();
Console.WriteLine(
    "5. Напишите программу, которая заполнит спирально массив 4 на 4."
);

Console.WriteLine();
Console.WriteLine("6. Выход из программы.");
Console.WriteLine();
Console.Write("Введите номер задачи: ");

int numberIssue = Convert.ToInt32(Console.ReadLine());
if (numberIssue <= 0 || numberIssue > 4)
{
    goto Start;
}
if (numberIssue == 6)
{
    Environment.Exit(0);
}

if (numberIssue == 1)
{
    int[,] matrix = new int[3,4];

    FillArray(matrix);
    Console.WriteLine("Исходный массив:");
    PrintArray(matrix);
    Console.WriteLine();
    Console.WriteLine("Отсортированный массив:");
    for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int k = j+1; k < matrix.GetLength(1); k++)
                {
                    if(matrix[i,k] < matrix[i,j])
                    {
                        int t = matrix[i,k];
                        matrix[i,k] = matrix[i,j];
                        matrix[i,j] = t;                
                    }
                }
                Console.Write(matrix[i,j] + "\t");
            }
            Console.WriteLine();

        }
    Continue();
    goto Start;
}

if (numberIssue == 2)

{
    
    int[,] matrix = new int[4,3];
    int[] sumElementRow = new int [matrix.GetLength(0)];

    FillArray(matrix);
    Console.WriteLine("Исходный массив:");
    PrintArray(matrix);
    Console.WriteLine();

    int minSumRow = 0;
    int minSum = int.MaxValue;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i,j];
        }
        sumElementRow[i] = sum;
        if(sumElementRow[i]<minSum)
        {
            minSum = sumElementRow[i];
            minSumRow = i;
        }

    }
    Console.WriteLine("Строка с наименьшей суммой: " + minSumRow);
    Continue();
    goto Start;

}

if (numberIssue == 3)

{
    
    int[,] matrix1 = new int[3,2];
    int[,] matrix2 = new int[2,3];
    
    FillArray(matrix1);
    Console.WriteLine("Матрица 1");
    PrintArray(matrix1);
    FillArray(matrix2);
    Console.WriteLine("Матрица 2");
    PrintArray(matrix2);


    Console.WriteLine();
    Console.WriteLine("Произведение матриц:");
    Console.WriteLine();

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            int resoult = 0;
            for (int k = 0; k < matrix1.GetLength(1)-1; k++)
            {
                for (int l = 0; l < matrix2.GetLength(0)-1; l++)
                {
                    resoult = (matrix1[i,k] * matrix2[l,j])
                            + (matrix1[i,k+1] * matrix2[l+1,j]);
                }
            }
            Console.Write(resoult + "\t");
        }
        Console.WriteLine();
    }      
    Console.WriteLine();
    Continue();
    goto Start;

}

if (numberIssue == 4)

{
    
    int[,,] matrix = new int[2,2,2];
    
    Console.WriteLine();
    Console.WriteLine("Трехмерный амссив:");
    Console.WriteLine();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                
                int num = 0;
                int [] array = new int[matrix.GetLength(0)*matrix.GetLength(1)*matrix.GetLength(2)];
                
                for (int l = 0; l < array.Length; l++)
                {
                    replay:
                    array[l] = new Random().Next(10);
                    if(array[l+1] == array[l])
                    {
                        l--;
                        goto replay;
                    }
                    else 
                    {
                        matrix[i,j,k] = array[l];
                    }
                }
                Console.Write($"{matrix[i,j,k]} ({i},{j},{k})   ");

            }
            Console.WriteLine();
        }
    }      
    Console.WriteLine();
    Continue();
    goto Start;

}
