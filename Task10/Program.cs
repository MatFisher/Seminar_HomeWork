Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

int SecOf3Digit(int num)
{
    int secDig = (num % 100)/10;
    return secDig;
}

if (number >= 100 && number <= 999)
{
int secondDigit = SecOf3Digit(number);
Console.Write($"Вторая цифра = {secondDigit}");
}
else Console.WriteLine("Введите корректное число");
