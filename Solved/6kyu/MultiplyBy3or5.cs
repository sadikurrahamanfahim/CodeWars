public static class Kata
{
    public static int Solution(int value)
    {
        int num = 0;

        if (value < 0)
        {
            return 0;
        }
        else
        {
            for (int i = 3; i < value; i++)
            {
                if (value % 3 == 0 || value % 5 == 0)
                {
                    num += i;
                }
            }
            return num;
        }
    }
}