//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Writeline("Введите число: ");
Console=string number.ReadLine();
number = len int.Length;
if (len==5);
{
    if (number [0] == number [4] && number [1] == number [3])
    {
        Console.WriteLine($"{number} - Палиндром");
    }
    else
    {
        Console.WriteLine($"{number} - НЕ палиндром");
    }
}
else
{
    Console.WriteLine($"ОШИБКА: {number} - не является пятизначным");
}

//Задача 21

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве
Console.Write("Введите координаты A: ");
double xA = double.Parse(Console.ReadLine());
double yA = double.Parse(Console.ReadLine());
double zA = double.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
double xB = double.Parse(Console.ReadLine());
double yB = double.Parse(Console.ReadLine());
double zB = double.Parse(Console.ReadLine());

double result = Math.Sqrt ((xA-xB-xZ)*(xA-xB-xZ) + (yA-yB-yZ)*(yA-yB-yZ));
Console.WriteLine($" расстояние между точками = {result}");

//Задача 23

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int number = ReadInt("Введите число N: ");

for (int i = 1; i <= number; i++)
{ 
    Console.Write($"{i*i*i} ");
}
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}