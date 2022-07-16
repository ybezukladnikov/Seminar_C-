// Необходимо задать двумерный массив. И написать программу,
// которая заменяет строки на столбцы.

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
    int [,] newArray = new int [array.GetLength(1), array.GetLength(0)];

    for (int i = 0; i<array.GetLength(0); i++)
    {
        for(int j = 0; j<array.GetLength(1); j++)
        {
            newArray[j,i] = array[i,j];
        }
    }
    return newArray;
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