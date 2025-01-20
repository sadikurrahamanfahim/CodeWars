using System;

public class Kata
{
    public static long FindNextSquare(long num)
    {
        long sqrt = (long)Math.Sqrt(num);
        if (sqrt * sqrt == num)
        {
            sqrt++;
            return sqrt * sqrt;
        }
        return -1;
    }
}
