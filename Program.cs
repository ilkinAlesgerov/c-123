// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateArray()
{
    int[] arr = new int[4];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(100,1000);
        System.Console.Write($"{arr[i]} ");
    }
    return arr;
}

void FindEvenNumbers(int[] array)
{
    int countEven = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]%2==0)
        {
            array[i] = 1;
            countEven += array[i];
        }
    }
    System.Console.WriteLine();
    System.Console.WriteLine(countEven);
}

FindEvenNumbers(CreateArray());




// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArray()
{
    int[] arr = new int[4];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(-10, 100);
        System.Console.Write($"{arr[i]} ");
    }
    return arr;
}


void DigitSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i%2==1)
        {
            sum += array[i];
        }
    }
    System.Console.WriteLine();
    System.Console.WriteLine(sum);
}

DigitSum(CreateArray());


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] CreateArray()
{
    int[] arr = new int[4];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(1, 100);
        System.Console.Write($"{arr[i]} ");
    }
    return arr;
}

void FindDif(int[] array)
{
    int max = 0;
    int min = array[0];
    var diff = 0;
    for (int i = 0; i < array.Length; i++)
    {

        if (array[i] > max)
        {
            max = array[i];

        }
        if (array[i] < min)
        {
            min = array[i];

        }
    }
    
    System.Console.WriteLine();
    System.Console.WriteLine($"{max} , {min}");
    diff = max - min;
    System.Console.WriteLine(diff);
}

FindDif(CreateArray());
