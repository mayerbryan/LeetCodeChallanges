using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeChallanges.LargestOddNumber
{
    public class LargestOddNumber
    {
        public string ReturnLargestOddNumber(string num) {
            int biggestOdd = 0;
            int evenCheck = 0;
            int number = Int32.Parse(num);

            if (num.Length > 6){
                Console.WriteLine("number is too big");
                return num;
            }
            if(num[0] == '0'){
                Console.WriteLine("number can not contain leading zeros");
                return null;    
            }

            if(number%2!=0){
                Console.WriteLine("is already an odd number");
                return num;
            }else{
                foreach(char c in num){
                    int i = (int)(c - '0');
                    
                    if(i%2==0){
                        evenCheck+=1;
                        if(evenCheck==num.Length){
                            Console.WriteLine("there is no odd numbers");
                            return "";
                        }
                    }else{
                        if(i > biggestOdd){
                            biggestOdd = i; 
                        }
                    }
                    
                }

            }
            Console.WriteLine(biggestOdd);
            return biggestOdd.ToString();
        }
    }
}