// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.

// int [] CreateArray()
// {
//     int [] arg = new int [12];
//     Random random = new Random();
//     for (int i = 0; i < 12; i++)
//         arg[i]= random.Next(-5,5);

//     return arg;

// }

// void ShowArray(int [] arg)
// {

//     Console.Write("Created array: [");    
//     for(int i =0; i<arg.Length; i++)
//     {
//         if (i == arg.Length - 1)
//         {
//             Console.Write(arg[i]);
//             break;
//         }
//         Console.Write(arg[i]+", ");
//     }
//     Console.Write("]");   
//     Console.WriteLine();   
    
// }

// int FindSum(int [] arg, bool isPositive)
// {

//     int sumPositive = 0;
//     int sumNegative = 0;

//     foreach(int el in arg)
//     {
//         if (el>0 && isPositive) sumPositive+=el;
//         else if (el<0 && !isPositive) sumNegative+=el;
     
//     }
    

//     return isPositive ? (sumPositive) : (sumNegative);

// }




// int[] myArray = CreateArray();
// ShowArray(myArray);

// bool isPositive = true;

// int sumPoz = FindSum(myArray,isPositive);
// Console.WriteLine("Sum pozitive num = "+ sumPoz);

// int sumNeg = FindSum(myArray, !isPositive);
// Console.WriteLine("Sum negativ num = "+ sumNeg);

// Написать программу, которая положительные элементы 
// сделает отрицательными, а отрицательные положительными. 

short[] CreateArray(short arg, short min, short max)
{
    short [] array = new short[arg];
    Random random = new Random();


    for (short i = 0; i < arg; i++)
    {
        array[i] = Convert.ToInt16(random.Next(min,max+1));
        
    }

    return array;
 
        
}

void ShowArray(short [] arg){

    Console.Write("Created array: [");    
    for(short i=0; i<arg.Length; i++)
    {
        if (i == arg.Length - 1)
        {
            Console.Write(arg[i]);
            break;
        }
        Console.Write(arg[i]+", ");
    }
    Console.Write("]");   
    Console.WriteLine();   
    
}

short[] ChangeArray(short[] arg)
{
    for (int i = 0; i < arg.Length; i++)
        arg[i]*=(-1);
    
    return arg;

}

Console.Write("Input size of array: ");
short size = Convert.ToInt16(Console.ReadLine());

Console.Write("Input lower range: ");
short min = Convert.ToInt16(Console.ReadLine());

Console.Write("Input upper range: ");
short max = Convert.ToInt16(Console.ReadLine());

short[] myArray = CreateArray(size, min, max);

ShowArray(myArray);

short[] newArray = ChangeArray(myArray);

ShowArray(newArray);




