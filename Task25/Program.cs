﻿/*  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
3, 5 -> 243 (3⁵)
2, 4 -> 16   */

int Exponent(int numberA, int numberB)
{
    int result = 1;
    for(int i = 1; i <= numberB; i++)
    {
        result = result*numberA;
    }
    return result;

}
Console.Write("Введите число А: ");
int numA = int.Parse(Console.ReadLine());
Console.Write("Введите число В: ");
int numB = int.Parse(Console.ReadLine());

int res = Exponent(numA, numB);
Console.WriteLine($"{numA}, {numB} -> {res}");

