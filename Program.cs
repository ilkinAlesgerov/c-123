// Задача 47.Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите значение для m: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение для n: ");
int columns = Convert.ToInt32(Console.ReadLine());



double[,] array = new double[rows, columns];
Random rnd = new Random();
void CreateArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10) + rnd.NextDouble();
            Console.Write(Math.Round(array[i, j], 1) + "\t");
        }
        Console.WriteLine();
    }
}
CreateArray();







// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17->такого числа в массиве нет

Console.WriteLine("Введите  первое значение  ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  второе значение ");
int num2 = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[3, 4];
Random rnd = new Random();

void CreateArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
CreateArray();

void FindElement(int[,] array)
{

    if (num1 > array.GetLength(0) || num2 > array.GetLength(1)) 
    {
        System.Console.WriteLine("такого числа в массиве нет");
    }
    else
    {
        int tmp = new int();
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] == array[num1, num2])
                {
                    tmp = array[i, j];
                }
            }
        }
        System.Console.WriteLine(tmp);
    }
}

FindElement(array);

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] array = new int[3, 4];
Random rnd = new Random();
CreateArray(array);

void CreateArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}



void FindAverageNumberInColumn(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double average = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            average += array[j, i];
        }
        average = Math.Round(average / array.GetLength(0), 1);
        Console.WriteLine($"столбца № {i + 1}-> {average}");
    }
}

FindAverageNumberInColumn(array);


