// Напишите программу, которая выводит случайное трёхзначное число 
// и удаляет вторую цифру этого числа.


int num = new Random().Next(100, 1000);
Console.WriteLine(num);


int numWhile = num;
int count = 0;

while (numWhile > 0 )
{
    count ++;
    numWhile /=10;
}
int[] array = new int[count];

 
for (int i = count-1; i >=0; i--)
{
array[i] = num%10;
num /=10;
}
    
string s1 = array[0].ToString();
string s2 = array[2].ToString();

int n = Convert.ToInt32(s1+s2);

Console.WriteLine(n);