﻿/*Задача 66: Задайте значения M и N. Напишите программу,
которая найдёт сумму натуральных элементов в промежутке
от M до N. Выполнить с помощью рекурсии.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int SumNumbers(int num1, int num2)
{
    if (num1 == num2)
        return num1;
    else
    {
        return SumNumbers(num1, num2 - 1) + num2;
    }
}
Console.WriteLine(SumNumbers(4,8));