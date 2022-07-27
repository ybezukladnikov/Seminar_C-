int Sum(int n)
{
    if(n<1) return 0;
    else
    {
        return n%10+ Sum(n/10);
    }

}

int sum = Sum(583);
Console.WriteLine(sum);