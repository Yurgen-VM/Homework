/*
Задача:
Написать программу, которая на вход принимает натуральное число N,
а на выходе показывает его цифры через запятую.

Пример: N = 485
На выходе: 4,8,5
*/

Console.Write("Введите любое натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    int i = 1;
    while (number /10 > 0)
    {
        number = number / 10;
        i++;
    } 
    Console.WriteLine($"{i}");
} 
else
{
    Console.WriteLine($"{number} не является натруальным числом. Введите другое значение!");
}