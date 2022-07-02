// Напишите программу, которая принимает на вход число (А) 
// и выдаёт сумму чисел от 1 до А.

// int findSum(int arg)
// {
//     int sum = 0;
//     for (int i = 1; i<=arg; i++)
//     {
//         sum = sum + i;

//     }
//     return sum;

// }

// Console.Write("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int sumF = findSum(num);
// Console.WriteLine(sumF);

// Напишите программу, которая принимает на вход число (А) 
// и выдаёт количество цифр в этом числе

// int findSum(int arg)
// {
//     int count = 0;
//     for (int i = Math.Abs(arg); i>1; i=i/10)
//     {
    
//         count++;

//     }
//     if (arg==0) count ++;
//     return count;

// }

// Console.Write("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int sumF = findSum(num);
// Console.WriteLine(sumF);


// Напишите программу, которая принимает на вход число (А) 
// и выдаёт произведение чисел от 1 до А.


int findSum(int arg)
{
    int count = 1;
    for (int i = 1; i<=arg; i++)
    {
    
        count*=i;

    }
    
    return count;

}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
int sumF = findSum(num);
Console.WriteLine(sumF);