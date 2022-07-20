// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumBetweenNum(int n, int m)
{
    if(n==m) 
        return n;
    else 
        return n+SumBetweenNum(n+1,m);
}

Console.Write("Input first number: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second number: ");
int m = Convert.ToInt32(Console.ReadLine());


int result = SumBetweenNum(n,m);
Console.WriteLine($"Sum between numbers is {result}");