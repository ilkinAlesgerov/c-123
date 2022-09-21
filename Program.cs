// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] CreateArray()
{
    int[] arr = new int[5];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] =  rnd.Next(-1000, 1000);
        System.Console.Write($"{arr[i]} ");
    }
    return arr;
}

int ShowMoreZero(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            array[i] = 1;
            count += array[i];

        }
    }
    Console.WriteLine();
    Console.WriteLine(count); 
    return count;

}

ShowMoreZero(CreateArray());

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// k1*x+b1 = k2*x +b2

// k1*x - k2*x = b2-b1

// x(k1-k2) = b2-b1; x = (b2-b1)/(k1-k2)

// y = k1 * (b2-b1)/(k1-k2) + b1,


double[,] points = new double[2, 2];
double[] crossPoint = new double[2];

void InputPoints()
{
    for (int i = 0; i < points.GetLength(0); i++)
    {
        if (i == 0) Console.WriteLine("значения для первого ур-ния");
        else Console.WriteLine("значения второго ур-ния");
        for (int j = 0; j < points.GetLength(1); j++)
        {
            if (j == 0) Console.WriteLine("Введите точку b");
            else Console.WriteLine("Введите число k");
            points[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }

}

double[] DigitCrossPoint()
{

    crossPoint[0] = (points[1,0] - points[0, 0]) / (points[0, 1] - points[1, 1]);
    crossPoint[1] = (points[0, 1] * crossPoint[0]) + points[0, 0];
    System.Console.WriteLine(points[1,1]-points[0,1]);
    return crossPoint;
}

void ShowCrossPoint(double[,] points)
{
    DigitCrossPoint();
    Console.WriteLine($"точка пересечения: ({crossPoint[0]}  ,  {crossPoint[1]})");
}

InputPoints();
ShowCrossPoint(points);