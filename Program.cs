using LeetCodeChallanges.LongestCommonPrefix;
using LeetCodeChallanges.ValidParentheses;


// int[] nums = {2,2,1,1,3};
// SingleNumber SingleNumber = new();
// SingleNumber.singleNumber(nums);

// string[] strs = {"flower","flow","flight"};
// LongestCommonPrefix LongestCommonPrefix = new ();
// LongestCommonPrefix.FindLongestCommonPrefix(strs);

string s = "()[]{}";
ValidParentheses validParentheses = new ();
Console.WriteLine(validParentheses.IsValid(s));

