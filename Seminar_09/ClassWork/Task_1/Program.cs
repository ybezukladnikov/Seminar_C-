// void Show(int n, int m)
// {
//     if (n==m)
//         Console.Write(n+ " ");
//     else
//     {
//         Console.Write(n + " ");
//         Show(n+1,m);
//     }
        
// }

// Show(5,9);

void Show(int n)
{
    
    if (n>1) Show(n-1);
    
    Console.Write(n + " ");
     
        
}

Show(5);
