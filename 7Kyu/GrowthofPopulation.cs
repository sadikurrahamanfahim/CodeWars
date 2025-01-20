using System;

class Arge
{

    public static int NbYear(int p0, double percent, int aug, int p)
    {
        int years = 0;
        double population = p0;

        while (population < p)
        {
            population += population * percent / 100 + aug;
            years++;
        }
        return years;
    }
}
