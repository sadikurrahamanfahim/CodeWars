using System;

public class Kata
{
    public static bool IsAValidMessage(string message)
    {
        int index = 0;
        for (int i = 0; i < message.Length; i++)
        {
            if (Char.IsDigit(message[i]))
            {
                string txt = message.Substring(index, i);
                Console.WriteLine(txt);
                if (txt.Length == (int)message[i] - 48)
                {
                    index = i +1;
                    return true;
                }
            }
        }

        return false; // jut to avoid error
    }

    public static void Main(string[] args)
    {
        // Example usage of the IsAValidMessage method
        string testMessage = "Hel3is a test message!";
        bool isValid = IsAValidMessage(testMessage);

        Console.WriteLine($"Is the message valid? {isValid}");
    }
}