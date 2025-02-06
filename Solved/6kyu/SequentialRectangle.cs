using System;
using System.Collections.Generic;

public class SqInRect
{
    public static List<int> sqInRect(int lng, int wdth)
    {
        if (lng == wdth)
        {
            return null;
        }

        List<int> squares = new List<int>();
        while (lng > 0 && wdth > 0)
        {
            if (lng > wdth)
            {
                squares.Add(wdth);
                lng -= wdth;
            }
            else
            {
                squares.Add(lng);
                wdth -= lng;
            }
        }
        return squares;
    }
}