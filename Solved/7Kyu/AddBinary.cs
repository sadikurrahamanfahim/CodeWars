using System;
public static class Kata
{
    public static string AddBinary(int a, int b)
    {
        int result = a + b;
        string str = "";
        
        if (result == 0)
            return "0";
            
        while (result > 0)
        {
            str = (result % 2) + str;
            result /= 2;
        }
        
        return str;
    }
}