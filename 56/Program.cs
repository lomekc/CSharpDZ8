﻿int[,] Random2dArray(int a, int b)
{
    while (a <= 0)
    {
        Console.Write("Строки должны быть > 0: ");
        a = Convert.ToInt32(Console.ReadLine());
    }

    while (b <= 0)
    {
        Console.Write("Столбцы должны быть > 0: ");
        b = Convert.ToInt32(Console.ReadLine());
    }

    int[,] new2dArray = new int[a, b];

    for (int i = 0; i < a; i++)
        for (int j = 0; j < b; j++)
            new2dArray[i, j] = new Random().Next(1, 10);

    return new2dArray;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
}

int[] SumOfElements(int[,] rectarray)
{
    int[] array = new int[rectarray.GetLength(0)];

    for (int k = 0, i = 0; k < rectarray.GetLength(0); k++, i++)
    {
        int sum = 0;
        for (int l = 0; l < rectarray.GetLength(1); l++)
        {
            sum = sum + rectarray[k, l];
        }
        array[i] = sum;
    }
    return array;
}

void SmallValue(int[] array)
{
    int min = array[0];
    int minindex = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
            minindex = i;
        }
    }
    Console.Write("Строка с минимальной суммой элементов - " + $"{minindex + 1}" + " (сумма элементов строки: " + min + ").");
}

int m = new Random().Next(3, 7);

int[,] my2dArray = Random2dArray(m, m);

Console.WriteLine("Сгенерированный двумерный массив:");

Show2dArray(my2dArray);

SmallValue(SumOfElements(my2dArray));

