// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int count = 0;
int FindPositive(int n)
{
    if (n == 0) return count;
    else 
    {
        Console.WriteLine("Input number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if(num>0) count++;
        FindPositive(n-1);
          
    }
    return count;
}



int myCount = FindPositive(3);
Console.WriteLine(myCount);