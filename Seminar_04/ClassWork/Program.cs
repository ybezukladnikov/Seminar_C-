// Напишите программу, которая принимает на вход число (А) 
// и выдаёт сумму чисел от 1 до А.

int findSum(int arg)
{
    int sum = 0;
    for (int i = 1; i<=arg; i++)
    {
        sum = sum + i;

    }
    return sum;

}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
int sumF = findSum(num);
Console.WriteLine(sumF);

