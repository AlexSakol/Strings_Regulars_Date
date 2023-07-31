Console.WriteLine("Введите строку");
string str = Console.ReadLine();
Console.WriteLine(DeleteDigits(str));

static string DeleteDigits(string s)
{
    for (int i = s.Length - 1; i >= 0; i--)
    {
        if (char.IsDigit(s[i]))
        {
            s = s.Remove(i, 1);
        }
    }
    return s;
}
