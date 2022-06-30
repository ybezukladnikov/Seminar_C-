// Напишите программу, которая принимает на вход координаты 
// двух точек и находит 
// расстояние между ними в 3D пространстве.

double getDistance(double xa, double ya, double za, double xb,double yb,double zb)
{
    double legX = xa - xb;
    double legY = ya - yb;
    double legZ = za - zb;

    double hypotenuseXYsquare = Math.Pow(legX,2)+Math.Pow(legY,2);
    double result = Math.Sqrt(hypotenuseXYsquare+Math.Pow(legZ,2));

    return result;

}

Console.Write("Input coordinate X dot A: ");
double xa = Convert.ToDouble(Console.ReadLine());

Console.Write("Input coordinate Y dot A: ");
double ya = Convert.ToDouble(Console.ReadLine());

Console.Write("Input coordinate Z dot A: ");
double za = Convert.ToDouble(Console.ReadLine());

Console.Write("Input coordinate X dot B: ");
double xb = Convert.ToDouble(Console.ReadLine());

Console.Write("Input coordinate Y dot B: ");
double yb = Convert.ToDouble(Console.ReadLine());

Console.Write("Input coordinate Z dot B: ");
double zb = Convert.ToDouble(Console.ReadLine());

double distanse = getDistance(xa, ya, za,xb, yb, zb);

Console.WriteLine($"Distance between dot A and dot B = {distanse}");



