// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3



int FindPositive(int n)
{
    int countPositiveNum = 0;


    for(int i = 1; i<=n; i++)
    {
        Console.WriteLine($"Input number # {i}: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if(num>0) countPositiveNum++;
    }
    

    return countPositiveNum;
}



int CheckCorrectNum()
{
    Console.WriteLine("Number of inspections should be a positive and greater than zero.");
    Console.Write("Input Number of inspections is ");
    int arg = Convert.ToInt32(Console.ReadLine());

    if (arg >0) return arg;
    else 
    {
        return CheckCorrectNum();
        
    }
    
}


Console.WriteLine();

int numOfInspections = CheckCorrectNum();

Console.WriteLine();

int numOfPositiveNumbers = FindPositive(numOfInspections);

Console.WriteLine();

Console.WriteLine($"Num of positive numbers is {numOfPositiveNumbers}");


