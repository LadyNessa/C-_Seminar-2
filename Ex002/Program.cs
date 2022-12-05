Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    if (number1 % number2 == 0)
    {
        Console.WriteLine("Первое число кратно второму");
    }
    else
    {
        Console.Write("Остаток: ");
        Console.WriteLine(number1 % number2);
    }
}
else
{
    if (number2 % number1 == 0)
    {
        Console.WriteLine("Второе число кратно первому");
    }
    else
    {
        Console.Write("Остаток: ");
        Console.WriteLine(number2 % number1);
    }
}