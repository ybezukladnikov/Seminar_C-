
// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumDigital(int arg)
{
    int sum = 0;
    for (int i = Math.Abs(arg); i>0.1; i/=10)
    {
        sum += i%10;
    }
    return sum;
}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Sum digitals in number is : " + SumDigital(num));