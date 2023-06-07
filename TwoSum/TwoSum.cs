
public class TwoSum
{
    int[] numbers = { 2, 7, 11, 15 };
    int target = 9;    

    public int[] twoSum(int[] numbers, int target)
    {

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[i] + numbers[j] == target)
                    return new int[] { i, j };
                    
            }
        }
        
        return null;
    }
}