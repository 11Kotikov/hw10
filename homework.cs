// Задача 25: Напишите программу, которая принимает на вход два числа (A и B) и возводит число 
// А в натуральную степень B (Math.Pow НЕ использовать)
// 3, 5 -> 243 (3⁵)
// 0, 0 - >1
// 2, 4 -> 16

// int NumberToThePower(int x, int n)
// {
//     int power = 1;
//     for (int i = 0; i < n; i++)
//     {
//         power *= x;
//     }
//     return power;
// }

// System.Console.WriteLine("Pls, Input the integer number you want to raise to a power:");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input the integer power:");
// int power = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("your result is " + NumberToThePower(num,power)+", aaaaand....What will you do with that information?"); 

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int CountOfDigits(int num)
{
    int sum = 0;
    int temp;
    while (num != 0)
    {
        temp = num%10;
        sum += temp;
        num = num / 10;
    }
    return sum;
}

System.Console.WriteLine($"Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write($"the sum of the numbers in the \"{num}\" is {CountOfDigits(num)}, Sooooo...another math from me, i'm not just a computer, i'm a calculator :'( ");

// Задача 29: Напишите программу, которая создает массив заданного пользователем размера, 
//заполняет массив элементами от 1 до 99 и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]