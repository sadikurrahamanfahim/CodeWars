using System;

public class Kata
{
    public static bool ValidatePin(string pin)
    {
        if (pin.Length == 4 || pin.Length == 6)
        {
            foreach (char c in pin)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
        return false;
    }
}
