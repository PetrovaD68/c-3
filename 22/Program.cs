﻿// Console.Clear();
// Console.Write("Введите число N: ");
// int N = int.Parse(Console.ReadLine());
// int[] result = new int[N];
// for (int i = 1; i <= N; i++)
//     result[i - 1] = i * i;
// for (int i = 0; i < N; i++)
//     Console.Write($"{result[i]} ");






Console.Clear();
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());
int i = 1;
int m = N; // m = -10  N = -1
// int count = 1;
// string s = (count * count).ToString() + (count != N ? ", " : "");
if (N < 0)
{
    i = N; //i = -10
    m = -N;// m = 10
    N = -1; // N = -1
}
int[] result = new int[m];
int j = 0;
for (; i <= N; i++)// 1 <= 0
{
    result[j] = i * i;
    j++;
}
for (j = 0; j < m; j++)
{
    Console.Write($"{result[j]} ");
}


// Console.Write($"{s} ");



// Console.Clear();
// Console.Write("Введите число N: ");
// int N = int.Parse(Console.ReadLine());
// int[] mas = new int[N];
// for (int i = 1; i <= N;i++)
//     mas[i - 1] = i * i;

// for (int i = 0; i < N; i++)
//     Console.Write($"{mas[i]} ");





// Задача 19: Напишите программу,которая принимает
//  на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 23432 -> да
// 12821 -> да


// Задача 21: Напишите программу, которая принимает
//  на вход координаты двух точек и находит расстояние между ними
//   в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Задача 23: Напишите программу, которая принимает 
// на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 4, 9. 
// 5 -> 1, 8, 27, 64, 125
