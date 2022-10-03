// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


System.Console.WriteLine("Введите значение для N");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(PrintNumber(num,1));

string PrintNumber(int start, int end)
{
    if (start == end)
    {
        return start.ToString();
    }
    return (start + "," + PrintNumber(start - 1, end));
}




// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


System.Console.WriteLine("Введите значение для M");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите значение для N");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(PrintNumber(num1, num2));

int PrintNumber(int start, int end)
{
    if (start == end)
    {

        return start;

    }
    return (start + PrintNumber(start + 1, end));
}




// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

System.Console.WriteLine("Введите значение для M");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите значение для N");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(PrintNumber(num1, num2));

int PrintNumber(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m != 0 && n == 0)
    {
        return PrintNumber(m - 1, 1);
    }
    else return PrintNumber(m - 1, PrintNumber(m, n - 1));
}
