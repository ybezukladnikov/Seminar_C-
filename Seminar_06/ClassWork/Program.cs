// Переворачивает массив. 

// int [] ChangeArray(int [] arg)
// {
//     int time=0;
//     for (int i = 0, j = arg.Length-1; i<j; i++, j--)
//     {
//         time = arg[i];
//         arg[i] = arg[j];
//         arg[j]= time;
//     }

//     return arg;

// // }

// void ShowArray(char [] arg){

//     Console.Write("Created array: [");    
//     for(int i=0; i<arg.Length; i++)
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

// int[] CreateArray(int arg)
// {
//     int [] array = new int[arg];
//     Random random = new Random();


//     for (short i = 0; i < arg; i++)
//     {
//         array[i] = Convert.ToInt16(random.Next(1,20));
        
//     }

//     return array;
 
        
// }

// int [] myArray = CreateArray(14);
// ShowArray(myArray);
// int [] newArray = ChangeArray(myArray);
// ShowArray(newArray);

// Переводит из десятичной в двоичную

// void  Cod(int arg)
// {
//     string result = string.Empty;
//     int count = 0;

//     while (arg>=1)
//     {
//         int tempr = arg%2;
//         result = result+ tempr.ToString();
//         arg /=2;
//         count++;
//     }

//     char [] myArray = new char[count];

//     for (int i = 0; i <count; i++ )
//     {
//         myArray[i] = result[i];
//     }  

//     for (int i = count-1; i>=0; i--)
//     {
//         Console.Write(myArray[i]);
//     }

    
// }

// Cod(20);


// Ряд фибоначи

void ShowArray(int [] arg){

    Console.Write("Created array: [");    
    for(int i=0; i<arg.Length; i++)
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



int[] Fibbonachi(int n)
{
    int [] array = new int[n];
    array[0] = 0;
    array[1] = 1;

    for(int i =2; i<n; i++)
    {
        array[i] = array[i-1] + array[i-2];
        Console.WriteLine(array[i]);
    }
    
    return array;

}

ShowArray(Fibbonachi(10));









