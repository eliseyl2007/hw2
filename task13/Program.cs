Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99)
{
    while (num > 999)
    {
    num = num / 10;
    }
    num = num % 10;
    Console.WriteLine($"Третья цифра ->{num}");
}
else
{
    Console.WriteLine("третьей цифры нет");
}