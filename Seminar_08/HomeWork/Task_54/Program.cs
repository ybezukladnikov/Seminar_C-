// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

int [,] CreateArray(int numOfLine, int numOfCol, int min, int max)
{
    int [,] myArray = new int [numOfLine,numOfCol];
    Random rand = new Random();

    for (int i =0; i<numOfLine; i++)
        for (int j = 0; j<numOfCol; j++)
            myArray[i,j] = rand.Next(min, max+1);

    return myArray;       
}

void ShowArray(int[,] array)
{
    Console.WriteLine();
    for (int i =0; i<array.GetLength(0); i++)
    {
        for (int j = 0; j<array.GetLength(1); j++)
            Console.Write(array[i,j]+" ");

        Console.WriteLine();
    }
    Console.WriteLine();    
}

int [,] ChangeArray(int[,] array)
{
    Console.WriteLine("New array: ");
    
    for(int i = 0; i<array.GetLength(0); i++)
    {
        
        for(int k = 0; k<array.GetLength(1); k++)
        {
            for(int j=0;j<array.GetLength(1)-1; j++)
        {
                if(array[i,j]<array[i,j+1])
                {
                    int tempriory = array[i,j+1];
                    array[i,j+1] = array[i,j];
                    array[i,j]= tempriory;

                }
            
        }
        }
        
    }

    return array;
}

Console.Write("Input number of line ");
int numOfLine = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number of column ");
int numOfColumn = Convert.ToInt32(Console.ReadLine());

int [,] myArray = CreateArray(numOfLine,numOfColumn,0,9);
Console.WriteLine("Created array: ");
ShowArray(myArray);

int [,] newArray = ChangeArray(myArray);
Console.WriteLine();
ShowArray(newArray);