Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

void Square(int num)
{
    int index = 1;
    int result = 0;
    while(index <= num)
    {
        result = index*index*index;
        Console.WriteLine($"{index, 5}  {result, 5}");
        index++;
    }
}

Square(number);