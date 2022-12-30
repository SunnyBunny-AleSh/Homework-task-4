//Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
//и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4-> 16
/*
Console.WriteLine("введите первым значением число, а втором степень числа");
int A = int.Parse(Console.ReadLine());
int B = int.Parse(Console.ReadLine());
int mult = 1;
for (int i = 0; i < B; i++)
{
    mult = (mult * A);
}
Console.WriteLine(mult);
*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
/*
using System;
using System.Security.Cryptography;

Console.WriteLine("введите число");
int number = int.Parse(Console.ReadLine());
string a = number.ToString();
int size = a.Length;
int sum = 0;

for (int i = 0; i < size; i++)
{
    sum = sum + number % 10;
    number = number / 10;
}
Console.WriteLine(sum);
*/

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
/*
Random r = new Random();
int[] massive = new int[8]; 
int number;
string print = string.Empty;
for (int i = 0; i<8; i++)
{
    number = r.Next(0, 9);
    massive[i] = number;
    print = print + massive[i]+", ";
}
Console.WriteLine(print);
*/