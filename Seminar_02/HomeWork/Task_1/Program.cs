// Задача 1: Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Input number ");

int num = Convert.ToInt32(Console.ReadLine());

int[] array = new int[3];

for (int i = 2; i >=0; i--)
{
    array[i] = num%10;
    num /=10;
}


Console.WriteLine(array[1]);






