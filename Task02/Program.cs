int numA, numB;
Console.WriteLine("Введите первое число");
numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
numB = Convert.ToInt32(Console.ReadLine());
if(numA>numB)
{
    Console.Write("Большее число = ");
    Console.WriteLine(numA);
    Console.Write("Меньшее число = ");
    Console.Write(numB);
}
else
{
    Console.Write("Большее число = ");
    Console.WriteLine(numB);
    Console.Write("Меньшее число = ");
    Console.Write(numA);
}