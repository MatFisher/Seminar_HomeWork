Console.WriteLine("Введите координату х первой точки");
int numX1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y первой точки");
int numY1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z первой точки");
int numZ1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату х второй точки");
int numX2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y второй точки");
int numY2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z второй точки");
int numZ2 = Convert.ToInt32(Console.ReadLine());

double Distance (int xOne, int yOne,int zOne, int xTwo, int yTwo, int zTwo)
{
    int x = xOne - xTwo;
    int y = yOne - yTwo;
    int z = zOne - zTwo;
    double dist = Math.Sqrt(x*x + y*y+z*z);
    return dist;
}

double result = Distance (numX1, numY1, numZ1, numX2, numY2, numZ2);
result = Math.Round(result, 2, MidpointRounding.ToZero);
Console.WriteLine(result);