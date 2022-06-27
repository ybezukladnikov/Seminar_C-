// Задача 1: Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.


// Первый спобоб через массив

// Console.Write("Input number ");

// int num = Convert.ToInt32(Console.ReadLine());

// void secondNum(int arg)
// {
//     int[] array = new int[3];

//     for (int i = 2; i >=0; i--)
//     {
//         array[i] = num%10;
//         num /=10;
//     }


//     Console.WriteLine(array[1]);
// }

// secondNum(num);

// Второй способ через деление

Console.Write("Input number ");

int num = Convert.ToInt32(Console.ReadLine());

int secondNum(int arg)
{
    int result = (arg/10)%10;
    return result;
 
}

int res = secondNum(num);

Console.WriteLine(res);
   



