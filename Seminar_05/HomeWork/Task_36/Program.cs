// Задача 36: Задайте массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

short [] CreateArray(int arg)
{
    short [] array = new short [arg];
    Random random = new Random();
    for(int i = 0; i< arg; i++)
        array[i] = Convert.ToInt16(random.Next(-50,51));

    return array;   
}

void ShowArray(short [] arg)
{

    Console.Write("Created array: [");    
    foreach(short el in arg)
    {
        if (el == arg[arg.Length - 1])
        {
            Console.Write(el);
            break;
        }
        Console.Write(el+", ");
    }
    Console.Write("]");   
    Console.WriteLine();   
    
}

short FindSum(short [] arg)
{
    short sum = 0;

    for (short i = 1; i < arg.Length; i+=2)
        sum +=arg[i];
    
    
    return sum;
}

Console.Write("Input size of array: ");
short size = Convert.ToInt16(Console.ReadLine());

short[] myArray = CreateArray(size);

ShowArray(myArray);

short sum = FindSum(myArray);
Console.WriteLine("The sum of number on odd position:  "+sum);

