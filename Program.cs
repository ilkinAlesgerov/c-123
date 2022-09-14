// Задача 1 
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// не использую math.pow

Console.WriteLine("Введите ваше 1oe число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите ваше 2oe число");
int number1 = Convert.ToInt32(Console.ReadLine());

int Vozvedenie(int num, int num2)
{
    int k = num2;
    int vozv = 1;
    for(int i = 1; i <= k; i++)
    {
        vozv *= num;
    }
    return vozv;
} 
Console.WriteLine(Vozvedenie(number, number1));

//                                              Задача №2
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите ваше  число");
int number = Convert.ToInt32(Console.ReadLine());

int DigitSum(int num)
{
    int sum = 0;
    while(num > 0)
    {
        sum += num%10;
        num /= 10;
    }
    return sum;
}

System.Console.WriteLine(DigitSum(number));

//                 задача 3 
// Напишите программу, которая выводит массив из 8 элементов, заполненный случайными числами.
// Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах)
// 1,2,5,7,19,1,2,8 -> 1,2,5,7,19,1,2,8 
//  -> 8

int[] CreateArray()
{
    Random rnd = new Random();
    var array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 100);
        System.Console.Write($"{array[i]},");
    }
    System.Console.Write("-> ");
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        
        Console.Write($"[{array[i]}]");
        
    }
    
}


ShowArray(CreateArray());


