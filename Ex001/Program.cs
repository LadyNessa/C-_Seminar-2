int N = new Random().Next(10,99);
Console.WriteLine(N);
int firstDigit = N / 10;
int secondDigit = N % 10;

if (firstDigit > secondDigit)
{
    Console.WriteLine(firstDigit);
}
else
{
    Console.WriteLine(secondDigit);
}