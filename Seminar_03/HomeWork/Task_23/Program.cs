// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void cubeNum(int arg)
{
    if (arg>0)
    {
        for(int i=1;i<=arg;i++)
    {
        
        double num = Math.Pow(i,3);
        
        if(i==arg)
        {
            Console.Write(num);
            break;
        }
        
        Console.Write($"{num},");
    }
    }
    else
    {
        for(int i=1;i>=arg;i--)
    {
        
        double num = Math.Pow(i,3);
        
        if(i==arg)
        {
            Console.Write(num);
            break;
        }
        
        Console.Write($"{num},");
    }
    }


    
}

Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
cubeNum(num);

