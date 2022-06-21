// Рандомно получает число и сравнивает первую цифру со второй. 

// int what = new Random().Next(10, 99);
// Console.WriteLine(what);

// int num1 = what / 10;
// int num2 = what % 10;

// if (num1 == num2)
// {
//     Console.WriteLine("Input number is even");
// }

// else
// {

//     if (num1 > num2)
// {
//     Console.WriteLine($"Max number is {num1}");
// }
// else 
// {
//     Console.WriteLine($"Max number is {num2}");
// }

// }


// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 

Console.Write("Input first number ");

int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second number ");

int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 % num2 == 0)
{
    Console.WriteLine("multiple");
}

else
{
    int div = num1 % num2;
    Console.WriteLine($"Remainder of division is {div}");
}