// Задайте массив строк. Напишите программу, которая генерирует 
// новый массив объединая
// элементы исходного массива попарно. 


string [] CreateArray(string[] array)
{
    int index = 0;
    if(array.Length%2>0) index = 1;
    string[] newArray = new string[array.Length/2+index];
    int j = 0;
    for(int i = 0; i<newArray.Length; i++)
    {
        if(j+1>=array.Length)
        {
            newArray[i] = array[j];
            break;
        }
        newArray[i] = array[j] + array[j+1];
        j+=2;
        
    }
    return newArray;
}

void ShowArray(string[] array)
{
    for(int i = 0; i<array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
        
}


string [] array = {"ert", "gjf", "tjbk", "gbju", "fdfb","dsfdsf"};

string [] newArray = CreateArray(array);

Console.WriteLine("Array: ");
ShowArray(array);

Console.WriteLine();

Console.WriteLine("New array: ");
ShowArray(newArray);