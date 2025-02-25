using System;

public class Kata
{
    public static int SquareDigits(int n)
    {
        string s = n.ToString();
        string ns = "";
        for (int i = 0; i < s.Length; i++)
        {
            int digit = s[i] - '0';
            ns += (digit * digit).ToString();
        }
        return int.Parse(ns);
    }
}