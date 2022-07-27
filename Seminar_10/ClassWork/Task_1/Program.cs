int NumOfWord(string [] array)
{
    int count = 0;
    foreach(string el in array)
    {
        if(el.Length>=5) count++;
    }

    return count;
}

string [] array = {"dfsfdf", "dfewrt", "df"};

Console.WriteLine(NumOfWord(array));