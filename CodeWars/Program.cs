using System;
using System.Collections.Generic;

public static class Kata {
    public static IEnumerable<string> FriendOrFoe (string[] names)
    {
        List<string> friends = new List<string>();
        for (int i = 0; i < names.Length; i++)
        {
            string name = names[i];
            if (name.Length == 4)
            {
                friends.Add(name);
            }
        }
        return friends;
    }
}