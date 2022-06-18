// int number = 5;
// Console.WriteLine($"My number is   {number}  and is good");

// Console.WriteLine("Input a number");
// int number = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Your number is {number}");

// Задача №1. Является ли первое число квадратом второго

// Console.WriteLine("Input first number");
// int numberFirst = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input second number");
// int numberSecond = Convert.ToInt32(Console.ReadLine());


// if (numberFirst * numberFirst == numberSecond)
// {
//     Console.WriteLine("Второе число равно квадрату первого");
// }

// else
// {
//    Console.WriteLine("Второе число не равно квадрату первого"); 
// }

// Задача №2 Про дни недели. 

// Console.Write("Input a number ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number == 1) Console.WriteLine("Monday");
// if (number == 2) Console.WriteLine("Wenthday");
// if (number == 3) Console.WriteLine("Thirstday");
// if (number == 4) Console.WriteLine("Thusday");
// if (number == 5) Console.WriteLine("Friday");
// if (number == 6) Console.WriteLine("Suterday");
// if (number == 7) Console.WriteLine("Sanday");

// else
// {
//    Console.WriteLine("There is not that day"); 
// }

// Задача № 3 Третий знак трехзначного числа. 

// Console.Write("Input number ");

// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(num%10);

// Задача№ 4 На входе получаем число на выходе выводим все значения от -N до N

Console.Write("Input number ");

int num = Convert.ToInt32(Console.ReadLine());

if (num<0)
{
    num = num * (-1);
}

int count = -num;


while (count <= num)
{
    Console.Write(count+ " ");
    count++;
}




