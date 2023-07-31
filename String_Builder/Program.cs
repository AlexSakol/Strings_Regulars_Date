using System.Text;

Console.WriteLine("Введите количество строк");
string result = Console.ReadLine();
int n;
if (int.TryParse(result, out n) && n > 0)
{
    Console.WriteLine($"Введите {n} строк через enter");
    StringBuilder[] stb = new StringBuilder[n];
    for (int i = 0; i < n; i++)
    {
        stb[i] = new StringBuilder(Console.ReadLine());
    }
    StringBuilder SB = new StringBuilder();
    Console.WriteLine(Mod(out SB, stb));
    Console.WriteLine(SB);
}
else { Console.WriteLine("Введено некорректное число строк"); }

static int Mod(out StringBuilder res, params StringBuilder[] mas) // join stings and return them
{
    for (int i = 0; i < mas.Length; i++)
    {
        Change(ref mas[i], i);
    }
    res = new StringBuilder(String.Join<StringBuilder>(";", mas));
    return res.EnsureCapacity(0);
}

static void Change(ref StringBuilder sb, int i) // Change substrings
{
    Console.WriteLine($"Введите заменяемую подстроку в строке {i + 1}");
    string sub1 = Console.ReadLine();
    Console.WriteLine("Введите подстроку на которую заменяется введенная подстрока");
    string sub2 = Console.ReadLine();
    sb.Replace(sub1, sub2);
}

