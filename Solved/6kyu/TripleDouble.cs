using System;
using System.Collections.Generic;

public class Kata
{
    public static int TripleDouble(long num1, long num2)
    {
        string num1Str = num1.ToString();
        string num2Str = num2.ToString();
        
        for (int i = 0; i < 10; i++)
        {
            string tripleDigit = i.ToString() + i.ToString() + i.ToString();
            string doubleDigit = i.ToString() + i.ToString();
            
            if (num1Str.Contains(tripleDigit) && num2Str.Contains(doubleDigit))
            {
                return 1;
            }
        }
        return 0;
    }
}