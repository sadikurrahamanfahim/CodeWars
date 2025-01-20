namespace Solution
{
    class Kata
    {
        public static int binaryArrayToNumber(int[] BinaryArray)
        {
            int[] array = new int[] { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512 };
            int count = 0;

            for (int i = 0; i < BinaryArray.Length; i++)
            {
                if (BinaryArray[BinaryArray.Length - i - 1] == 1)
                {
                    count += array[i];
                }
            }
            return count;
        }
    }
}