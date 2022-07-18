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

int [,] FillArray(int [,] array)
{

    int count =0;
    int temp=1;

    if(array.GetLength(0)<2)  array[0,0] = 1;
    
    else
    {
        if(array.GetLength(0)<3) temp=0;

        while(count<array.GetLength(0)/2+temp)
        {

            for(int i =count, j=count; j<array.GetLength(1)-count; j++)
        {
            if(i==0 && j == 0)
                array[i,j] = 1;
            else
                array[i,j]= array[i,j-1]+1;

        }

            for(int i =count+1, j=array.GetLength(1)-(count+1); i<array.GetLength(0)-count; i++)
            {
                array[i,j] = array[i-1,j]+1;
            }

            for(int i =array.GetLength(0)-(count+1), j=array.GetLength(1)-(count+2); j>=count; j--)
            {
                array[i,j] = array[i,j+1]+1;
            }

            for(int i = array.GetLength(0)-(count+2), j= count; array[i,j]==0;i--)
            {
                array[i,j] = array[i+1,j]+1;
            }
            count+=1;

        }
    }


    return array;
}

Console.Write("Input number of line ");
int numOfLine = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number of column ");
int numOfColumn = Convert.ToInt32(Console.ReadLine());

int [,] array = new int [numOfLine,numOfColumn];

int [,] newArray = FillArray(array);

ShowArray(newArray);

