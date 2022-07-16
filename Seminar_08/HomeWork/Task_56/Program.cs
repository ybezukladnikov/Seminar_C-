// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с 
// наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт 
// номер строки с наименьшей суммой элементов: 1 строка

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

int ValueOfLine(int[,] array, int max)
{
    int min = max*array.GetLength(1)+1;
    int count = 0;
    for (int i =0; i<array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j =0; j<array.GetLength(1); j++)
        {
            sum += array[i,j];
        }
        if(sum<min)
        {
            min = sum;
            count = i;
        }

    }
        
    return count;
}

Console.Write("Input number of line ");
int numOfLine = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number of column ");
int numOfColumn = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min of Range ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max of Range ");
int max = Convert.ToInt32(Console.ReadLine());

int [,] myArray = CreateArray(numOfLine,numOfColumn,min, max);
Console.WriteLine("Created array: ");
ShowArray(myArray);

int valueOfLine = ValueOfLine(myArray,max);
Console.WriteLine($"Number of Line with min value sum elements is: {valueOfLine}");
