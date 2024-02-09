/*
Задача:
Написать программу, которая принимает на вход
координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
и выдаёт номер координатной четверти плоскости, в которой находится эта точка.
*/

int sector_1 = 1;
int sector_2 = 2;
int sector_3 = 3;
int sector_4 = 4;
 
Console.Write("Введите значение x: ");
int x = Convert.ToInt32(Console.ReadLine());
if (x == 0)
{ 
    Console.WriteLine ("x - не может быть равено нулю. Введите другое значение");
}
else
{
    Console.Write("Введите значение y: ");
    int y = Convert.ToInt32(Console.ReadLine());
    if (y == 0) 
    {
        Console.WriteLine("y - не может быть равено нулю. Введите другое значение");
    }
    else
    {
        if (x > 0 && y > 0)
        {
             Console.WriteLine($"Точка находится четверти координат № {sector_1}");
        }
        if (x < 0 && y > 0)
        {
            Console.WriteLine($"Точка находится четверти координат № {sector_2}");
        }
        if (x < 0 && y < 0)
        {
            Console.WriteLine($"Точка находится четверти координат № {sector_3}");
        }
        if (x > 0 && y < 0)
        {
            Console.WriteLine($"Точка находится четверти координат № {sector_4}");
        }
    }
}
