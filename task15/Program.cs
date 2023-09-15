Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());

bool result = DayOff (num);
Console.WriteLine(result ? "Да" : "Нет");

bool DayOff(int num)
{
    return(num == 6 || num ==7);
}