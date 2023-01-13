// See https://aka.ms/new-console-template for more information
public class Program
{
    public static void Main()
    {
        string[] roman = new string[] { "III", "IV", "IX", "LVIII", "MCMXCIV" };
        foreach (string s in roman)
        {
            Console.WriteLine($"{s} = {RomanToInt(s)}");
        }
    }

    public static int RomanToInt(string s)
    {
        Dictionary<char, int> roman = new Dictionary<char, int>();
        roman.Add('I', 1);
        roman.Add('V', 5);
        roman.Add('X', 10);
        roman.Add('L', 50);
        roman.Add('C', 100);
        roman.Add('D', 500);
        roman.Add('M', 1000);
        int result = roman[s[s.Length - 1]];
        for (int i = s.Length - 2; i >= 0; i--)
        {
            if (roman[s[i]] < roman[s[i + 1]])
            {
                result -= roman[s[i]];
            }
            else
            {
                result += roman[s[i]];
            }
        }
        return result;
    }
}


