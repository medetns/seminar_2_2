/*Задача 21. Напишите программу, которая принимает на вход 
координаты двух точек и находит расстояние между ними в 3D пространстве. */

double x1, x2, y1, y2, z1, z2;

Console.WriteLine("Enter x coordinate of first point");
x1 = double.Parse(Console.ReadLine());

Console.WriteLine("Enter y coordinate of first point");
y1 = double.Parse(Console.ReadLine());

Console.WriteLine("Enter z coordinate of first point");
z1 = double.Parse(Console.ReadLine());

Console.WriteLine("Enter x coordinate of second point");
x2 = double.Parse(Console.ReadLine());

Console.WriteLine("Enter y coordinate of second point");
y2 = double.Parse(Console.ReadLine());

Console.WriteLine("Enter z coordinate of second point");
z2 = double.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2) + Math.Pow(z2-z1,2));
Console.WriteLine(result);