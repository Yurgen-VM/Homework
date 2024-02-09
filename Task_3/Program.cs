/*
Задача:
Написать программу, которая принимает на вход целое число из отрезка [10, 99]
и показывает наибольшую цифру числа.
*/

using System.ComponentModel.DataAnnotations;

Console.Write("Введите число в диапазоне [10, 99] ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 10 && number <= 99)
{
    int leftDigit = number / 10;
    int rightDigit = number % 10;
    int max = leftDigit;
        if (rightDigit > leftDigit)
        {
            max = rightDigit;
        }
    Console.WriteLine ($"Наибольшая цифра = {max}");
}
else
{
    Console.WriteLine($"{number} не удовлетворяет условиям, введите другое число!");
}

    
    
    
    