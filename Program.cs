//              задача № 19

Console.WriteLine("Введите пятизначное число:");
int isPalindrome = Convert.ToInt32(Console.ReadLine());

void CheckPalindrome(int num)
{
    
    if ( isPalindrome > 10000 && isPalindrome < 100000)
    {
        string str = num.ToString();
        if (str[0] == str[4] && str[1] == str[3])
        {
            Console.WriteLine("да");
        }
        else
        {
            Console.WriteLine("нет");
        }
    }
}

CheckPalindrome(isPalindrome);



//              Задача № 21 

Console.WriteLine("Введите x1:");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите y1:");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите z1:");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите x2:");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите y2:");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите z2:");
int z2 = Convert.ToInt32(Console.ReadLine());


double GetDistance( int x1, int y1, int z1, int x2, int y2,  int z2)
{
    double distance = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2) + Math.Pow(z2-z1,2));
    return distance;
}

Console.WriteLine(GetDistance(x1, y1, z1, x2, y2, z2)); 


//              Задача № 23 

Console.WriteLine("Введите ваше число");
int number = Convert.ToInt32(Console.ReadLine());

void GetDashboard(int num)
{
    for (int i = 1; i <= num; i++)
    {
        Console.WriteLine(Math.Pow(i,3));
    }
}

GetDashboard(number);
