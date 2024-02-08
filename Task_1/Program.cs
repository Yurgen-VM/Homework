/*
Задача:
Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23
*/

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 7 == 0)
{
    if (number % 23 ==0)
    {
        Console.WriteLine("Число кратно 7 и 23");
    }
}
else
{
    Console.WriteLine("Число не кратно 7 и 23"); 
} 
