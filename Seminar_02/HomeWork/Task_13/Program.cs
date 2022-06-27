// Задача 3: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

// Первый способ через массив



Console.Write("Input number ");

int num = Convert.ToInt32(Console.ReadLine());

// void thirdNum(int arg)
// {
//     int numWhile = Math.Abs(num);
//     int count = 0;

//     while (numWhile > 0 )
//     {
//         count ++;
//         numWhile /=10;
//     }
//     int[] array = new int[count];

//     if (count < 3)
//     {
//         Console.WriteLine("There is not third number");
//     }

//     else
//     {
        
//         for (int i = count-1; i >=0; i--)
//     {
//         array[i] = Math.Abs(num%10);
//         num /=10;
//     }
//         Console.WriteLine(array[2]);
//     }
// }

// thirdNum(num);


// Второй способ. Делением. 


void thirdNum(int arg)
{
    double argAbs = Math.Abs(arg);
    double interResult=0;
    int interResult_1;

    if (argAbs < 100)
    {
        Console.WriteLine("There is not third number");
    }
        
    else 
    {
        while (argAbs>1)
        {
            argAbs/=10;
            interResult = argAbs;
            
        }
        interResult *=1000;
        interResult_1 = (int)interResult;
        int result = interResult_1%10;
        Console.WriteLine($"Third number is {result}");

    }    
}

thirdNum(num);

