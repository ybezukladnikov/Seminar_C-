// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int [] CreateArray(int arg)
{
    int [] array = new int[arg];

    for (int i = 0; i<arg; i++)
        array[i]= new Random().Next(0,100);

    return array;
}

void ShowArray(int [] arg)
{
    for(int i = 0; i<arg.Length; i++)
        Console.Write(arg[i] + " ");
}

Console.Write("Input size array: ");
int size = Convert.ToInt32(Console.ReadLine());

int [] myArray = CreateArray(size);
ShowArray(myArray);