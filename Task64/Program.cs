// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());

void SumNumb(int num)
{
    if(num == 0) return;
    Console.Write($"{num} ");
    SumNumb(num - 1);
}

SumNumb(number);