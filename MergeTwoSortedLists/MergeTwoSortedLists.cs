using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeChallanges.MergeTwoSortedLists
{
    public class MergeTwoSortedLists
    {
        
        public void MergeTwoLists(List<int> list1, List<int> list2) {
            List<int> list3 = new List<int>();
            foreach (var item in list1)
            {
                list3.Add(item);
            }
            foreach (var item in list2)
            {
                list3.Add(item);
            }
            list3.Sort();
            foreach (var item in list3)
            {
                Console.WriteLine(item);
            }

            
        }
    }
}