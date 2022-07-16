// Задача 60. Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет построчно 
// выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

int [,,] array = new int[2,2,2]{{{34,54},{67,55}},{{66,79},{23,34}}};

void ShowArray(int [,,] array)

{
    for(int i=0; i<array.GetLength(0); i++)
    {
        Console.WriteLine();
        for(int j=0; j<array.GetLength(1); j++)
            for(int k=0; k<array.GetLength(2); k++)
                Console.Write($"{array[i,j,k]} ({i},{j},{k})");
    }
        
        
}

ShowArray(array);