using System;

public static class Kata
{
    public static string Likes(string[] name)
    {
        if (name.Length < 1)
        {
            return "no one likes this";
        }
        else if (name.Length == 1)
        {
            return $"{name[0]} likes this";
        }
        else if (name.Length == 2)
        {
            return $"{name[0]} and {name[1]} like this";
        }
        else if (name.Length == 3)
        {
            return $"{name[0]}, {name[1]} and {name[2]} like this";
        }
        else
        {
            int others = name.Length - 2;
            return $"{name[0]}, {name[1]} and {others} others like this";
        }
    }
}