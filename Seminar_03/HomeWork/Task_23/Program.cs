// На вход принимаем число. 

void cubeNum(int arg)
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

Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
cubeNum(num);

