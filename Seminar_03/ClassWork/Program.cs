void findQuarter(int arg1, int arg2)
{
    if (arg1>0 & arg2>0) Console.WriteLine("1 quarter");
    if (arg1<0 & arg2>0) Console.WriteLine("2 quarter");
    if (arg1<0 & arg2<0) Console.WriteLine("3 quarter");
    if (arg1>0 & arg2<0) Console.WriteLine("4 quarter");
}

Console.Write("Input first coordinate: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Input first coordinate: ");
int y = Convert.ToInt32(Console.ReadLine());

findQuarter(x,y);