public static class Kata
{
    public static int sumTwoSmallestNumbers(int[] numbers)
    {
        int small = int.MaxValue;
        int secondSmall = int.MaxValue;

        foreach (int num in numbers)
        {
            if (num < small)
            {
                secondSmall = small;
                small = num;
            }
            else if (num < secondSmall)
            {
                secondSmall = num;
            }
        }

        return small + secondSmall;
    }
}


// return numbers.OrderBy(i => i).Take(2).Sum(); //best solution have seen so far
// System.Array.Sort(numbers); return numbers[0]+numbers[1];