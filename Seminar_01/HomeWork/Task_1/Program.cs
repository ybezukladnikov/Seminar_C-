// Задача 2: Напишите программу, которая на вход принимает два числа 
// и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Input first number");
int numberFirst = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second number");
int numberSecond = Convert.ToInt32(Console.ReadLine());

if (numberFirst == numberSecond)
{
    Console.WriteLine("The entered numbers are the same");
}

else
{
    if (numberFirst<numberSecond) 
    {
        Console.WriteLine($"Max numbers is {numberSecond}");
    }
    else
    {
        Console.WriteLine($"Max numbers is {numberFirst}");
    }
}




    