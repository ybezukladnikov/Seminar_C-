// Рандомно получает число и сравнивает первую цифру со второй. 

// int what = new Random().Next(10, 99);
// void maxMin()
// {
//     int arg = new Random().Next(10, 100);
//     Console.WriteLine("Current number is "+ arg);
//     int num1 = arg / 10;
//     int num2 = arg % 10;
//     int max = num1;

//     if (num2 > max) max = num2;
//     Console.WriteLine("Bigger digit  is " + max);

// }

// maxMin();

// Напишите программу, которая выводит случайное трёхзначное число 
// и удаляет вторую цифру этого числа.


// int num = new Random().Next(100, 1000);
// Console.WriteLine(num);

// int Delete(int arg)
// {
//     int numWhile = arg;
//     int count = 0;

//     while (numWhile > 0 )
//     {
//         count ++;
//         numWhile /=10;
//     }
//     int[] array = new int[count];

    
//     for (int i = count-1; i >=0; i--)
//     {
//     array[i] = num%10;
//     num /=10;
//     }
        
//     string s1 = array[0].ToString();
//     string s2 = array[2].ToString();

//     int n = Convert.ToInt32(s1+s2);
//     return n;

// }

// int test = Delete(num);
// Console.WriteLine(test);


// Напишите программу, которая будет принимать на вход два 
// числа и выводить, является ли второе число кратным первому. 



Console.Write("Input first number ");

int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second number ");

int num2 = Convert.ToInt32(Console.ReadLine());

void multiple(int arg1, int arg2)
{
    if (num1 % num2 == 0)
    {
        Console.WriteLine("multiple");
    }

    else
    {
        int div = num1 % num2;
        Console.WriteLine($"Remainder of division is {div}");
    }    
}

multiple(num1, num2);


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