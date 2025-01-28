using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static int GetUnique(IEnumerable<int> numbers)
    {
        var groupedNumbers = numbers.GroupBy(x => x);
        int uniqueNumber = groupedNumbers.Single(g => g.Count() == 1).Key;

        return uniqueNumber;
    }
}