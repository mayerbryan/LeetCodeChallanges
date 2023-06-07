using System.Text;

public static class CharExtensions{

    public static string reverseString(this char[] s){
        StringBuilder sb = new StringBuilder();
        for (int i = s.Length - 1; i >= 0; i--)
        {
            sb.Append(s[i]);
        }
        
        return sb.ToString();
    }
}