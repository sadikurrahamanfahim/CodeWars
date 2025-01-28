using System.Text;

namespace Solution
{
    public static class SpacesRemover
    {
        public static string NoSpace(string input)
        {
            StringBuilder sb = new StringBuilder(); 
            foreach (var c in input)
            {
                if (c != ' ')
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }
    }
}