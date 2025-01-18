using System;

public class Kata
{
    public static string Remove_char(string s)
    {
      String str = "";
      for(int i = 1; i < s.Length-1; i++)
        {
        str += s[i];
      }
        return str; // Your Code
    }
}