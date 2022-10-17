// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.

Console.Clear();

Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
SumAllNumbers(M, N);


void SumAllNumbers(int M, int N, int sum = 0)
{
    if (N == M) Console.Write(sum += M);
    else 
    {
        sum += M;
        SumAllNumbers(++M, N, sum);
    }
}
