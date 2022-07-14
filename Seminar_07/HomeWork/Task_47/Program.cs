// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] CreateArray(int numOfLine, int numOfColumn)
{
    double [,] array = new double[numOfLine,numOfColumn];
    Random rand = new Random();
    
    for (int i = 0; i<numOfLine; i++)
    {
        for(int j = 0; j<numOfColumn; j++)
        {
            array[i,j] = Math.Round(rand.NextDouble()*100,2);
        }
    }

    return array;

}

void ShowArray(double [,] array)
{
    for (int i = 0; i<array.GetLength(0); i++)
    {
        for(int j = 0; j<array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+"  ");
        }
        Console.WriteLine();

    }
}


Console.Write("Input number of line ");
int numOfLine = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number of column ");
int numOfColumn = Convert.ToInt32(Console.ReadLine());


double [,] myArray = CreateArray(numOfLine,numOfColumn);

ShowArray(myArray);

