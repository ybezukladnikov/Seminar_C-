// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

short [] CreateArray(short arg)
{
    short [] array = new short[arg];
    Random random = new Random();
    foreach (short i in array)
    {
        array[i] = Convert.ToInt16(random.Next(100,1000));
        
    }
    return array;
        
}

short Count(short [] arg)
{
    short count = 0;
    foreach (short i in arg)
    {
        if (arg[i]%2==0)
            count++;
    }

    return count;
}

short count = Count(CreateArray(4));
Console.WriteLine(count);


