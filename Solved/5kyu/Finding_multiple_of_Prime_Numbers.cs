public static class Kata
{
    public static int findThem(int number_limit, int[] primes)
    {
        int sum = 0;

        if (number_limit < 0)
        {
            return 0;
        }
        
        for (int i = 0; i < number_limit; i++)
        {
            if (IsNatural(i, primes))
            {
                sum += i;
            }
        }
        return sum;
    }

    private static bool IsNatural(int value, int[] primes)
    {
        if (value < primes[0]) 
            return false; 

        for (int i = 0; i < primes.Length; i++)
        {
            if (value % primes[i] == 0)
            {
                return true;
            }
        }
        return false;
    }
}