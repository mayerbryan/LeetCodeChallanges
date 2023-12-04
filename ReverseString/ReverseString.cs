
using System.Text;
namespace LeetCodeChallanges.ReverseString;
public static class ReverseString {    
    public static void reverseString(char[] s) {        
        Array.Reverse(s);        
        Console.WriteLine(s);
    }
}