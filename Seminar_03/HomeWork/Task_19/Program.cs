// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.


Console.Write("Input number ");

int num = Convert.ToInt32(Console.ReadLine());

void findPol(int arg)
{
    int numWhile = Math.Abs(num);
    int count = 0;

    while (numWhile > 0 )
    {
        count ++;
        numWhile /=10;
    }
    int[] array = new int[count];
     
    for (int i = count-1; i >=0; i--)
    {
        array[i] = Math.Abs(num%10);
        num /=10;
    }
    
    int count1 = 0;

    int n =1;
    if(count%2==0) n=0;
    for (int i = (count/2)-1, j = (count/2)+n; i>=0; i--, j++)
    {
        if(array[i]==array[j]) count1++;
    }
    
    if(count1==count/2)
        Console.WriteLine("Yes. Input number is polindrom");
    else    
        Console.WriteLine("No. Input number is not polindrom");

    
    
}

findPol(num);