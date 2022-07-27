DateTime dt = DateTime.Now; 

int CreateRandNum(int [,,] array)
{

    int rand = new Random().Next(1,8001);
    int count =0;
    foreach (int el in array)
    {
        if(el == rand) count = 1;
    }

    if(count==0) return rand;
    else return CreateRandNum(array);

}

void ShowArray(int [,,] array)

{
    for(int i=0; i<array.GetLength(0); i++)
    {
        Console.WriteLine();
        for(int j=0; j<array.GetLength(1); j++)
            for(int k=0; k<array.GetLength(2); k++)
                Console.Write($"{array[i,j,k]}({i},{j},{k}) ");
    }
        
        
}

int [,,] FillArray(int [,,]array)
{
    for(int i= 0; i<array.GetLength(0);i++)
    {
        for(int j= 0; j<array.GetLength(1);j++)
        {
            for(int k=0; k<array.GetLength(2); k++)
            {
                array[i,j,k]=CreateRandNum(array);
            }
        }
        
    }
    return array;
}



int[,,] array = new int[20,20,20];

int[,,] filledArray = FillArray(array);

Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);

// ShowArray(filledArray);



// void Show(int [] array)
// {
//     for(int i=0; i<array.Length; i++)
//         Console.Write(array[i]+ " ");
// }
// Show(array);
