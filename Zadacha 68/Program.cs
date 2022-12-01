/*Задача 68: Напишите программу вычисления функции Аккермана
с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

int FunAkkerman(int num, int arg)
{
    if (num == 0)
        return arg + 1;
    else if (arg == 0)
    {
        return FunAkkerman(num - 1, 1);
    }
    return FunAkkerman(num - 1, FunAkkerman(num, arg - 1));
}
Console.WriteLine(FunAkkerman(3, 2));
