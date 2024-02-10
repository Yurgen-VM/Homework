/*
Задача:
Написать программу, которая на вход принимает натуральное число N,
а на выходе показывает его цифры через запятую.

Пример: N = 485
На выходе: 4,8,5
*/

using System.Globalization;

Console.Write("Введите любое натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int number_temp = number;
int amauntDigit = 1;

if (number_temp > 9)
{
    for (amauntDigit = 1; number_temp / 10 > 0; amauntDigit++)
    {
        number_temp = number_temp / 10;
        amauntDigit = amauntDigit++;
    } 
    //Console.WriteLine($"{amauntDigit}, {number}");


    int divisor = 10;
    for (divisor = 10; amauntDigit > 2; amauntDigit--)
    {
        divisor = divisor * 10;
    } 
    //Console.WriteLine($"делитель равен: {divisor}");
   
   
    int digit = 1;
    while (divisor > 1)
    {
        digit = number / divisor;
        divisor/= 10;
        if (digit >= 10)
        {
            digit %= 10; 
        }
        Console.Write($"{digit},");    
    }
    Console.Write($"{number % 10}");  
} 
else
{
    if (number_temp >= 0)
    {
        Console.WriteLine($"{number}");
    }
    else
    {
        Console.WriteLine($"{number} не является натруальным числом. Введите другое значение!");
    }
    
}
