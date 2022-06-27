// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Input number ");
int num = Convert.ToInt32(Console.ReadLine());


void dayWeek(int arg)
{
    if (arg<=7 & arg >=1)
    {
        if (arg<=5 & arg >=1)
            Console.WriteLine("Working day");

        else 
            Console.WriteLine("Day off");    
    }
    else
    {
        Console.WriteLine("Input number is not correct");
    }
}


dayWeek(num);

