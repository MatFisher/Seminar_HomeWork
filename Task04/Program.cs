int numA, numB, numC;
Console.WriteLine("Введите первое число");
numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
numB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
numC = Convert.ToInt32(Console.ReadLine());
int max=numA;

if(max < numB) max = numB;
if(max < numC) max = numC;

Console.Write("Максимальное число = ");
Console.WriteLine(max);