// Первая задача 

// void findQuarter(int arg1, int arg2)
// {
//     if (arg1>0 & arg2>0) Console.WriteLine("1 quarter");
//     if (arg1<0 & arg2>0) Console.WriteLine("2 quarter");
//     if (arg1<0 & arg2<0) Console.WriteLine("3 quarter");
//     if (arg1>0 & arg2<0) Console.WriteLine("4 quarter");
// }

// Console.Write("Input first coordinate: ");
// int x = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input first coordinate: ");
// int y = Convert.ToInt32(Console.ReadLine());

// findQuarter(x,y);

/*
Вторая задача Напишите программу, которая по заданному номеру 
четверти, показывает диапазон возможных координат точек в этой 
четверти (x и y).
*/

void showRange(int arg)
{
    if(arg == 1) Console.WriteLine("Coordinate X is positive and Coordinate Y is positive");
    if(arg == 2) Console.WriteLine("Coordinate X is negative and Coordinate Y is positive");
    if(arg == 3) Console.WriteLine("Coordinate X is negative and Coordinate Y is negative");
    if(arg == 4) Console.WriteLine("Coordinate X is positive and Coordinate Y is negative");
    if(arg < 1 | arg >4) Console.WriteLine("Input number is not correct");
}

Console.WriteLine("Input number of quarter: ");
int quarter = Convert.ToInt32(Console.ReadLine());

showRange(quarter);

