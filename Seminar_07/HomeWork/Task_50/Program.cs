// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет



                          
void FindNum(int [,] array, int positionLine, int positionCol)
{
  
    
    if (positionLine>array.GetLength(0) || positionCol>array.GetLength(1)) 
    {
        Console.WriteLine("The numbers at such positions are not in the array");
    }
        
    else
    {
       Console.WriteLine($"The numbers at such positions is: {array[positionLine,positionCol]}");
    }    
     
}

void ShowArray(int [,] array)
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


int [,] array = new int [,] {{1,2,3},{3,4,4},{67,34,1}};

ShowArray(array);

Console.WriteLine();

Console.Write("Input value of line ");
int valueOfLine = Convert.ToInt32(Console.ReadLine());

Console.Write("Input value of column ");
int valueOfColumn = Convert.ToInt32(Console.ReadLine());

FindNum(array,valueOfLine,valueOfColumn);