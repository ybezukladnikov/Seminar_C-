int what = new Random().Next(10, 99);
Console.WriteLine(what);

int num1 = what / 10;
int num2 = what % 10;

if (num1 == num2)
{
    Console.WriteLine("Input number is even");
}

else
{

    if (num1 > num2)
{
    Console.WriteLine($"Max number is {num1}");
}
else 
{
    Console.WriteLine($"Max number is {num2}");
}

}
