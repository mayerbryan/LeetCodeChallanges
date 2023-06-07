


public static class RomanToInt {
    string userInput = Console.ReadLine();
    int result;
    public static void romanToInt(){
        char[] userInputArray = userInput.ToCharArray(); 
        for(int i=0; i <= userInput.Length; i++){
                       
            if (i == userInput.Length - 1){
                Console.WriteLine(i);
                    switch (userInputArray[i]){                        
                        case 'I':                            
                                result += 1;                            
                            break;
                        case 'V':
                            result += 5;
                            break;
                        case 'X':                            
                                result += 10;                            
                            break;
                        case 'L':
                            result += 50;
                            break;
                        case 'C':                            
                                result += 100;                            
                            break;
                        case 'D':
                            result += 500;
                            break;
                        case 'M':
                            result += 1000;
                            break;                        
                    } 
                }else if(i <= userInput.Length - 1){
                    switch (userInputArray[i]){                                               
                        case 'I':                        
                            if (userInputArray[i+1] == 'V' | userInputArray[i+1] == 'X' ){                                
                                result -= 1;                               
                            }else{
                                result += 1;
                            }
                            break;
                        case 'V':
                            result += 5;
                            break;
                        case 'X':
                            if (userInputArray[i+1] == 'L' | userInputArray[i+1] == 'C' ){
                                result -= 10;
                                
                            }else{
                                result += 10;
                            }
                            break;
                        case 'L':
                            result += 50;
                            break;
                        case 'C':
                            if (userInputArray[i+1] == 'D' | userInputArray[i+1] == 'M'){
                                result -= 100;
                            }else{
                                result += 100;
                            }
                            break;
                        case 'D':
                            result += 500;
                            break;
                        case 'M':
                            result += 1000;
                            break;                        
                    }  
                }
        }
        Console.WriteLine(result);
    }

}