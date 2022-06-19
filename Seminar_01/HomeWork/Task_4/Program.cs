// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.Write("Input first number ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second number ");
int n2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input third number ");
int n3 = Convert.ToInt32(Console.ReadLine());

int max = n1;

if (n2>max) max=n2;
if (n3>max) max=n3;

if (n1*n2*n3==n1*n1*n1)
{
    Console.WriteLine("The entered numbers are the same");
}
else
{
    Console.WriteLine($"Max number is {max} ");
}


