using System;
using System.Linq;

public static class Kata
{
    public static int happyCoding(string nickname)
    {
        nickname = nickname.ToLower(); 

        switch (nickname)
        {
            case "happy coding":
                return 1;
            case "coding happy":
                return 2;
            case "coding everyday":
                return 3;
            case "happy programmer":
                return 4;
            default:
                if (nickname.Contains("happy") && nickname.Contains("coding"))
                {
                    return 5; 
                }
                return 0;
        }
    }
}