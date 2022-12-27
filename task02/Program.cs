/*
 Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int GetSum(int m, int n, int sum)
{
    if (m == n)
    {
        return sum + n;
    }
    else
    {
         sum = m + GetSum (m+1, n, sum);
         return sum;
    }
}
Console.WriteLine(GetSum(4,8,0));