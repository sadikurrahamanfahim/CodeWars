using System;
public class Kata
{
    public static string Rot13(string input)
    {
        string rot13 = "";
        foreach (char n in input)
        {
            if (n >= 'a' && n <= 'z')
            {
                if (n + 13 <= 'z')
                {
                    rot13 +=(char)(n + 13);
                }
                else
                {
                    var overflow = n + 13;
                    var extra = overflow - 'z';
                    var offsetFromstart = extra + 'a';
                    char startincludedoffset = (char)(offsetFromstart - 1);
                    
                    rot13 += startincludedoffset;
                }
            }
            else if (n >= 'A' && n <= 'Z')
            {
                var overflow = (n - 'A') + 13;
                var mod = overflow % 26;
                var final = mod + 'A';
                
                rot13 += (char)final;
            }
            else
            {
                rot13 += n.ToString();
            }
        }

        return rot13;
    }
    
}