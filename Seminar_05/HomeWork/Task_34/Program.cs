// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

short[] CreateArray(short arg)
{
    short [] array = new short[arg];
    Random random = new Random();


    for (short i = 0; i < arg; i++)
    {
        array[i] = Convert.ToInt16(random.Next(100,1000));
        
    }

    return array;
 
        
}

void ShowArray(short [] arg){

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

short Count(short [] arg)
{
    short count = 0;
    foreach (short i in arg)
    {
        if (i%2==0)
            count++;
    }

    return count;
}


Console.Write("Input size of array: ");
short size = Convert.ToInt16(Console.ReadLine());
short[] myArray = CreateArray(size);

ShowArray(myArray);

short count = Count(myArray);
Console.WriteLine("The number of even numbers is "+count);

