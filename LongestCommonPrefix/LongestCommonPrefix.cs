using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeChallanges.LongestCommonPrefix
{
    public class LongestCommonPrefix
    {
        public string FindLongestCommonPrefix(string[] strs)
{
            if (strs.Length == 0)
                return "";
            
            string prefix = strs[0];
            
            for (int i = 1; i < strs.Length; i++)
            {
                while (strs[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                    
                    if (prefix.Length == 0)
                        return "";
                }
            }
            
            return prefix;
        }
    }
}