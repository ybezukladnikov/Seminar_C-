// Задача 6: Напишите программу, которая на вход принимает 
// число и выдаёт, является ли число чётным 
// (делится ли оно на два без остатка).

Console.Write("Input number ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine("Input number is even");
}
else
{
    Console.WriteLine("Input number is odd");
}