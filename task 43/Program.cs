﻿//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



Console.Write("Введите значения точки b1: ");
double b1 = double.Parse(Console.ReadLine());
Console.Write("Введите значения точки k1: ");
double k1 = double.Parse(Console.ReadLine());
Console.Write("Введите значения точки b2: ");
double b2 = double.Parse(Console.ReadLine());
Console.Write("Введите значения точки k2: ");
double k2 = double.Parse(Console.ReadLine());
GetIntersectionPoint (b1,k1,b2,k2);

void GetIntersectionPoint (double b1,double k1,double b2,double k2)
{
        double x = (b2-b1) /(k1-k2);
        double y = k1 * x + b1;
        if (k1!=k2)
        {
           Console.WriteLine ( $"Прямые пересекаются в точке ({x}; {y})");
        }
        else 
        {
             Console.WriteLine ( "Прямые  не пересекаются!");
        }

}
