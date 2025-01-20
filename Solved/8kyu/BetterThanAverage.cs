public class Kata
{
    public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
    {
      int avg = 0;
        for (int i = 0; i<ClassPoints.Length; i++)
          {
          avg += ClassPoints[i];
}
      avg = avg/ClassPoints.Length;
      if (avg<YourPoints){return true;}
      else
        return false;
    }
}