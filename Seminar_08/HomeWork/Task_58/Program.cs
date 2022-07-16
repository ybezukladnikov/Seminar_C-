﻿// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

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

int [,] NewArray(int[,] array1, int[,] array2)
{
    Console.WriteLine("New array: ");
    int[,] newArray = new int[array1.GetLength(0),array1.GetLength(1)];

    for(int i =0; i<array1.GetLength(0); i++)
        {
            for(int j =0; j<array1.GetLength(1); j++)
            {
                newArray[i,j] = array1[i,j] * array2[i,j];
            }
        }
    
    

    return newArray;
}

Console.Write("Input number of line ");
int numOfLine = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number of column ");
int numOfColumn = Convert.ToInt32(Console.ReadLine());

int [,] myArray1 = CreateArray(numOfLine,numOfColumn,0,4);
Console.WriteLine("Created array: ");
ShowArray(myArray1);

int [,] myArray2 = CreateArray(numOfLine,numOfColumn,0,4);
Console.WriteLine("Created array: ");
ShowArray(myArray2);

int [,] newArray = NewArray(myArray1,myArray2);
Console.WriteLine();
ShowArray(newArray);