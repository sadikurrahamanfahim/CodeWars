using System;
class Arge
{
    public static int NbYear(double p0, double percent, int aug, int p)
    {
        int years = 0;
        while (p0 < p)
        {
            p0 += Math.Floor(p0 * percent * 0.01 + aug);
            years++;
        }
        return years;
    }
}