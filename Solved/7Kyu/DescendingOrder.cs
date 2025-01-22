using System;

public static class Kata
{
    public static int DescendingOrder(int num)
    {
        string desc = num.ToString();
        char[] arr = desc.ToCharArray();
        Array.Sort(arr);
        Array.Reverse(arr);
        
        return int.Parse(new string(arr));
    }
}