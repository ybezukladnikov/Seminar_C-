// Необходимо задать двумерный массив. И написать программу,
// которая занулит строку и столбец где находится нименьший элемент. 

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

(int,int) FindMinValue(int[,] array)
{
    int line= 0;
    int column = 0;
    int min = array[0,0];
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j = 0; j<array.GetLength(1); j++)
        {
            if(array[i,j]<min)
            {
                min = array[i,j];
                line = i;
                column = j;
            }
        }
    }
    return (line, column);
}

int [,] ChangeArray(int [,] array, int line, int column)
{
    for(int i = 0; i<array.GetLength(1); i++)
    {
        array[line,i] = 0;
    }

      for(int i = 0; i<array.GetLength(0); i++)
    {
        array[i,column] = 0;
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

(int, int) myTriple = FindMinValue(myArray);
Console.WriteLine($"{myTriple.Item1} {myTriple.Item2}");


int [,] newArray = ChangeArray(myArray,myTriple.Item1, myTriple.Item2);
Console.WriteLine();
ShowArray(newArray);