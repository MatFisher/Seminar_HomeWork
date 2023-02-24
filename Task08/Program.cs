Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());

if(number > 0)
{
    int count = 2;
    while(count<=number)
    {
        Console.Write (count + " ");
        count = count+2;
    
    }

}
else 
{
    Console.WriteLine ("Введено не натуральное число");
}