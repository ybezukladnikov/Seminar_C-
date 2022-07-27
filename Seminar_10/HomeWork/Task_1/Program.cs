// Задайте массив строк. Напишите программу, которая считает 
// количество слов начинающихся на гласную букву. 



int NumOfVowel(string [] array)
{
    string vowel = "eyuioa";
    int count = 0;
    for(int i =0; i<array.Length; i++)
    {
        foreach (char el in vowel)
        {
            if(el == array[i][0]) count++;
        }
    }
    

    return count;
}

string [] array = {"ete", "erg", "trh", "art"};
Console.WriteLine($"Num of word beginning with vowel is  {NumOfVowel(array)}");