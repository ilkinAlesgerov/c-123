//                                   Задача №2 
Console.Clear();                            
Console.WriteLine("Введите  первое число ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите  второе число ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2) {
    Console.WriteLine(num1);
} else {
     Console.WriteLine(num2);
}

//                                  Задача №4

Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2 && num1 > num3) {
     Console.WriteLine(num1);
} else if  (num2 > num1 && num2 > num3) {
     Console.WriteLine(num2);
} else if (num3 > num1 && num3 > num2) {
     Console.WriteLine(num3);
}
//                               Задача 6 
Console.WriteLine("Введите число");
int num  = Convert.ToInt32(Console.ReadLine());

if (num % 2==1 ) {
    Console.WriteLine("da");
} else {
    Console.WriteLine("нет");
} 
 

//              Задача № 8 
Console.WriteLine("Введите число");
int num  = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i < num;i++)
    if (i % 2==0) {
        Console.WriteLine(i);
    }