// Задача 64: Задайте значение N. 
// Напишите программу, которая найдет факториал числа N рекурсивным методом.
// N = 4 -> 24

int Factorial(int n)
{
    if (n==1 || n==0) 
        return 1;
    else 
        return n*Factorial(n-1);
}

Console.Write("Input number: ");
int n = Convert.ToInt32(Console.ReadLine());

int factorialOfNum = Factorial(n);

Console.Write($"Factorial of number is {factorialOfNum}");
