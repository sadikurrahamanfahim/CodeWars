using System;

public static class Kata
{
    public static string Disemvowel(string str)
    {
        string result = "";
        foreach (char c in str)
        {
            if (c != 'a' && c != 'e' && c != 'i' && c != 'o' && c != 'u' &&
                c != 'A' && c != 'E' && c != 'I' && c != 'O' && c != 'U')
            {
                result += c;
            }
        }

        return result;
    }
}
