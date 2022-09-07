/* Задача 23
Напишите программу, которая принимает на вход 
число (N) и выдаёт таблицу кубов чисел от 1 до N. */

int number = int.Parse(Console.ReadLine());

int index = 1;

while (index <= number)
{
    Console.WriteLine(index*index*index);
    index++;
}