Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int x = number2 % number1;

if (x == 0)
{
    Console.WriteLine("Второе число кратно первому");
}
else
{
    Console.Write("Остаток: ");
    Console.WriteLine(x);
}