using System;

public class Kata
{
    public static bool IsIsogram(string str)
    {
        String str1 = str.ToLower();
        for (int i = 0; i < str1.Length; i++)
        {
            for(int j = i+1; j < str1.Length; j++)
            {
                if(str1[i]==str1[j])
                {return false;}
            }
        }
        return true;
    }
}