// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

void CreateArray(int arg)
{
    int [] array = new int[arg];
    Random random = new Random();
    foreach (int i in array)
    {
        array[i] = random.Next(100,1000);
        Console.WriteLine(array[i]);
    }

    Console.WriteLine(array[0]);
    
        
}

CreateArray(14);

// short[] myArray =CreateArray(8);
// Console.WriteLine(myArray[7]);
// foreach(short i in myArray)
//     Console.WriteLine(myArray[i]);


// short Count(short [] arg)
// {
//     short count = 0;
//     foreach (short i in arg)
//     {
//         if (arg[i]%2==0)
//             count++;
//     }

//     return count;
// }

// short count = Count(CreateArray(4));
// Console.WriteLine(count);


