int Pow(int a, int b)
{
    if(b==1) return a;
    else return a*Pow(a,b-1);
}

Console.WriteLine(Pow(3,4));