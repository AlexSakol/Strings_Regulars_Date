
Console.WriteLine("Введите дату");
string date = Console.ReadLine();
int days;
Days(in date, out days);
Console.WriteLine($"Кол-во дней до конца месяца: {days}");

static void Days(in string date, out int days) // Days to the end of  month
{
    DateTime now;
    DateTime.TryParse(date, out now);
    DateTime last = new DateTime(now.Year, now.Month + 1, 1).AddDays(-1);
    var d = last.Subtract(now);
    days = d.Days;   
}

