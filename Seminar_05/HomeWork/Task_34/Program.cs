// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

// short[] CreateArray(short arg)
// {
//     short [] array = new short[arg];
//     Random random = new Random();
//     for (short i = 0; i < arg; i++)
//     {
//         array[i] = Convert.ToInt16(random.Next(100,1000));
        
//     }

//     return array;
 
        
// }

// short[] myArray = CreateArray(8);

// void ShowArray(short [] arg)
// {
//     // for (short i = 0; i<arg.Length; i++)
//     // {
//     //     Console.WriteLine(arg[i]);
//     // }
        

//     foreach(short el in arg)
//     {
//         Console.WriteLine(arg[el]);
//     }
        
// }

// ShowArray(myArray);



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



short [] nums = {4,4,2,1,5,6,3};
foreach(short el in nums)
    {
        Console.WriteLine(nums[el]);
    }