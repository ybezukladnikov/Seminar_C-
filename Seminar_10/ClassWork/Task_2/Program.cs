// Написать программу принимающую на вход массив строк. 
// Программа должна возвращать новый массив из элементов начинающихся 
// на символ s1 и заканчиваюхихся на символ s2.

string [] CreateArray(string []array, char s1, char s2)
{
    string [] temp = new string[array.Length];
    int count = 0;
    int index = 0;
    
    foreach(string el in array)
    {
        if(el[0]==s1 && el[el.Length-1]==s2)
        {
            count++;
            temp[index] = el;
            index++;
        } 

    }
    string [] newArray = new string[count];
    
    for (int i = 0; i< count; i++)
    {
        newArray[i] =  temp[i]; 
    }

    return newArray;
}

string[] myArray = {"Tom", "Jhon"};

Console.Write("Input number: ");
char n = Convert.ToChar(Console.ReadLine());

string[] newArray = CreateArray(myArray, n, 'm');

Console.WriteLine(newArray[0]);