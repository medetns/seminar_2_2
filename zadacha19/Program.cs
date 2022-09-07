Console.WriteLine("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());
if (number / 10000 == number % 10 && number / 1000 % 10 == number / 10 % 10) 
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}