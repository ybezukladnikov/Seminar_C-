// Необходимо задать двумерный массив. И написать программу,
// которая поменяет первую и последнию строки массива. 

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
    int i = 0;
    int k = array.GetLength(0)-1;
    int tempriory;
    for(int j = 0; j<array.GetLength(1); j++)
    {
        tempriory = array[i,j];
        array[i,j] = array[k,j];
        array[k,j] = tempriory;

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