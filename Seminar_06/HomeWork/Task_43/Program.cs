// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)


(double x, double y) FindCoordinate(double k1, double b1, double k2, double b2)
{
    double x = Math.Round((b2-b1)/(k1-k2),2);
    double y = Math.Round((x*k1+b1),2);

    return (x, y);
}

Console.WriteLine("Input coefficients for the first equation: ");
Console.Write("k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input coefficients for the second equation: ");
Console.Write("k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

Console.Write("b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

if (k1 == k2 && b1 != b2)
    Console.WriteLine("Two straight lines are parallel.");

else if (k1 == k2 && b1 == b2) 
    Console.WriteLine("Two straight lines coincide.");

else 
{
    (double, double) Coordinate = FindCoordinate(k1,b1,k2,b2);

    Console.WriteLine($"Intersection coordinates of two line: x = {Coordinate.Item1}, y = {Coordinate.Item2}");

}    


