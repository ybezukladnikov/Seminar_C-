// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Input number ");
int numInput = Convert.ToInt32(Console.ReadLine());

int absNumInput = Math.Abs(numInput);
if (absNumInput == 1 | absNumInput == 0) 
{
    Console.WriteLine("There is not even number from 1 to N");
}
else
{
    int count = 2;
    if (numInput>0)
    {
        while (count <= numInput)
        {
            if (count+2<numInput)
            {
                Console.Write($"{count},");
                count = count +2;
            }
            else
            {
                Console.Write($"{count}");
                count = count +2;
            }
        }
    }
    else
    {
        while (count <= absNumInput)
        {
            if (count+2<absNumInput)
            {
                Console.Write($"{count*(-1)},");
                count = count +2;
            }
            else
            {
                Console.Write($"{count*(-1)}");
                count = count +2;
            }
        }
    }
}


