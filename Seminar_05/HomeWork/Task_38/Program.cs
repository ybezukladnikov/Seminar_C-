// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


double [] CreateArray(short arg)
{
    double [] array = new double [arg];
    Random random = new Random();
    int [] rangN = {1, 10, 100, 1000};
    
    for(int i = 0; i< arg; i++)
    {
        int n = rangN[random.Next(0,4)];
        array[i] = Math.Round(random.NextDouble()*n-n/2,2);
    }
       
       

    return array;   
}

void ShowArray(double [] arg)
{

    Console.Write("Created array: [");    
    foreach(double el in arg)
    {
        if (el == arg[arg.Length - 1])
        {
            Console.Write(el);
            break;
        }
        Console.Write(el+" ");
    }
    Console.Write("]");   
    Console.WriteLine();   
    
}

double FindMax(double [] arg)
{
    double max = arg[0];

    foreach (double el in arg)
    {
        if (max<el) max = el;
    }

    return max;
}

double FindMin(double [] arg)
{
    double min = arg[0];

    foreach (double el in arg)
    {
        if (min>el) min = el;
    }

    return min;
}

double FindDif(double arg1, double arg2)
{

    double dif = Math.Round((arg1 - arg2),2);

    return dif;
}

Console.Write("Input size of array: ");
short size = Convert.ToInt16(Console.ReadLine());

double[] myArray = CreateArray(size);

ShowArray(myArray);

double maxNum = FindMax(myArray);
Console.WriteLine("Max number is "+maxNum);

double minNum = FindMin(myArray);
Console.WriteLine("Min number is "+minNum);

double dif = FindDif(maxNum, minNum);

Console.WriteLine("Difference between max number and min number is "+dif);

