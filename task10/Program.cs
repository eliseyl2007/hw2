Console.WriteLine("Введите трех значное число:");
int num = Convert.ToInt32(Console.ReadLine());

int numb = num / 10;
int number = numb % 10;
Console.WriteLine($"вторая цифра ->{number}");