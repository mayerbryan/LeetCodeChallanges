using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace LeetCodeChallanges.CountOfMatchesInTournament
{
    public class CountOfMatchesInTournament
    {
        public int NumberOfMatches(int n) {
            int numberOfTeams = n;
            int numberOfMatches = 0;

            while(numberOfTeams > 0){               
                if ( numberOfTeams%2 == 0 && numberOfTeams>1){
                    numberOfTeams = numberOfTeams / 2;  
                    numberOfMatches += numberOfTeams;                  
                }else if(numberOfTeams%2!=0 && numberOfTeams>1){
                    numberOfTeams = (numberOfTeams - 1)/2; 
                    numberOfMatches += numberOfTeams;
                    numberOfTeams = numberOfTeams + 1;                                       
                }else{
                    numberOfTeams = 0;
                }                
            }
            return numberOfMatches;
        }
    }
}