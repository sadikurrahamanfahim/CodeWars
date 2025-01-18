public static class Kata
{
    public static int sumTwoSmallestNumbers(int[] numbers)
    {
        int small = Math.Min(numbers[0], numbers[1]);
        int secondSmall = Math.Max(numbers[0], numbers[1]);

        for (int i = 2; i < numbers.Length; i++)
        {
            if (numbers[i] < small)
            {
                secondSmall = small;
                small = numbers[i];
            }
            else if (numbers[i] < secondSmall)
            {
                secondSmall = numbers[i];
            }
        }
        
        return small + secondSmall;
    }
}