// Console.Write("Input number ");

// int num = Convert.ToInt32(Console.ReadLine());

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
     
//     for (int i = count-1; i >=0; i--)
//     {
//         array[i] = Math.Abs(num%10);
//         num /=10;
//     }
    
//     int count1 = 0;

//     for (int i = (count/2)-1, j = (count/2)+1; i>=0; i--, j++)
//     {
//         if(array[i]==array[j]) count1++;
//     }
    
//     if(count1==2)
//         Console.WriteLine("Yes");
//     else    
//         Console.WriteLine("No");

//     Console.WriteLine(count1);
    
// }

// thirdNum(num);


Console.Write("Input number ");

int num = Convert.ToInt32(Console.ReadLine());

void thirdNum(int arg)
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
        Console.WriteLine("Yes");
    else    
        Console.WriteLine("No");

    Console.WriteLine(count1);
    
}

thirdNum(num);