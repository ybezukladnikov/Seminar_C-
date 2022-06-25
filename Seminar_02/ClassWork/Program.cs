// Рандомно получает число и сравнивает первую цифру со второй. 

int what = new Random().Next(10, 99);
void maxMin()
{
    int arg = new Random().Next(10, 100);
    Console.WriteLine("Current number is "+ arg);
    int num1 = arg / 10;
    int num2 = arg % 10;
    int max = num1;

    if (num2 > max) max = num2;
    Console.WriteLine("Bigger digit  is " + max);

}

maxMin();


// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 

// Console.Write("Input first number ");

// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input second number ");

// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 % num2 == 0)
// {
//     Console.WriteLine("multiple");
// }

// else
// {
//     int div = num1 % num2;
//     Console.WriteLine($"Remainder of division is {div}");
// }

// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.


// Console.Write("Input number ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num % 23 == 0 & num % 7 == 0)
// {
//     Console.WriteLine("Yes");
// }
// else
// {
//     Console.WriteLine("No");
// }