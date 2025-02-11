using System;

public class Number
{
    public static int DigitalRoot(long n)
    {
        if (n < 10)
        {
            return (int)n;
        }
        long sum = 0;
        while (n > 0)
        {
            sum += n % 10;
            n /= 10;
        }
        return DigitalRoot(sum);
    }
}