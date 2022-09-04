//              задача № 10 
Console.WriteLine("Введите ваше число");
int number = Convert.ToInt32(Console.ReadLine());

void Multiple(int num)
{
    if (num > 100 && num < 1000 )
    {
        int result = num % 100; 
        int secondNum = result / 10;
        Console.WriteLine(secondNum);
    } 
    else
    {
        Console.WriteLine("недопустимое число");
    }
}

Multiple(number); 

//              задача № 13
Console.WriteLine("Введите ваше число");
int number = Convert.ToInt32(Console.ReadLine());

void Multiple(int num)
{
    if ( num > 100 && num < 1000 ) 
    {
        // int result = number % 100;
        // int secondNum = result % 10;
        Console.WriteLine((num % 100) % 10);
    } 
    if (num < 100)
    {
        Console.WriteLine("третьей цифры нет");
    }
    else if (num > 1000)
    {
        string str = num.ToString();

        // int num1 = number % 1000;
        // int num2 = num1 / 100; 
        Console.WriteLine(str[2]);   
    }
}
Multiple(number);

//  задача № 15


Console.WriteLine("Введите ваше число");
int number = Convert.ToInt32(Console.ReadLine());

void Multiple(int num)
    {
        if (num < 6)
        {
            Console.WriteLine("нет");
        }
        if (num == 6 || num == 7)
        {
            Console.WriteLine("да");
        }
        else if (num > 7)
        {
            Console.WriteLine("не корректное число");
        }
    } 

Multiple(number);