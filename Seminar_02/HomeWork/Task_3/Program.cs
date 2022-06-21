// Задача 3: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

Console.Write("Input number ");

int num = Convert.ToInt32(Console.ReadLine());

int numWhile = Math.Abs(num);
int count = 0;

while (numWhile > 0 )
{
    count ++;
    numWhile /=10;
}
int[] array = new int[count];

if (count < 3)
{
    Console.WriteLine("There is not third number");
}

else
{
    
    for (int i = count-1; i >=0; i--)
{
    array[i] = Math.Abs(num%10);
    num /=10;
}
    Console.WriteLine(array[2]);
}

