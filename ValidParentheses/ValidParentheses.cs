using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeChallanges.ValidParentheses
{
    public class ValidParentheses
    {
        public bool IsValid(string s) {
            while(s.Contains("()") || s.Contains("[]") || s.Contains("{}"))
            {
                s=s.Replace("()","").Replace("[]","").Replace("{}","");
            }
            return s.Length == 0;
            
            
        }
    }
}