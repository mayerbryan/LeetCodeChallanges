using LeetCodeChallanges.LongestCommonPrefix;
using LeetCodeChallanges.ValidParentheses;
using LeetCodeChallanges.MergeTwoSortedLists;


// int[] nums = {2,2,1,1,3};
// SingleNumber SingleNumber = new();
// SingleNumber.singleNumber(nums);

// string[] strs = {"flower","flow","flight"};
// LongestCommonPrefix LongestCommonPrefix = new ();
// LongestCommonPrefix.FindLongestCommonPrefix(strs);

// string s = "()[]{}";
// ValidParentheses validParentheses = new ();
// Console.WriteLine(validParentheses.IsValid(s));

List<int> list1 = new List<int>{1,2,4};
List<int> list2 = new List<int>{1,3,4};
MergeTwoSortedLists mergeTwoSortedLists = new ();
mergeTwoSortedLists.MergeTwoLists(list1,list2);