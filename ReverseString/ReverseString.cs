
using System.Text;

public static class ReverseString {
    static readonly StringBuilder sb = new StringBuilder();
    public static void reverseString(char[] s) {
        for (int i = s.Length - 1; i >= 0; i--)
        {
            sb.Append(s[i]);
        }
        Console.WriteLine(sb.ToString());
    }
}