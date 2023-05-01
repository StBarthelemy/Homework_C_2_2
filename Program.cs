Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(number);

if (number < 100)
{
Console.WriteLine("третьей цифры нет");
}
else
{

while (number > 1000)
{
    number = number/10;
}
Console.WriteLine($"Третья цифра, {number % 10} ");
}
