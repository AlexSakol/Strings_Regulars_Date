using System.Text.RegularExpressions;


Console.WriteLine("Введите строку");
string str = Console.ReadLine();
Console.WriteLine(EnglishDelete(ref str));

static string EnglishDelete(ref string s) //Delete english chars
{
    Regex regex = new Regex("[a-zA-Z]");
    s = regex.Replace(s, "");
    return s;
}

