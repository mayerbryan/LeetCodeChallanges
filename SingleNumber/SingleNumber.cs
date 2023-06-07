



public class SingleNumber
{
    
    public int singleNumber(int[] nums)
    {
        int xor = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            xor ^= nums[i];
        }
        Console.WriteLine(xor);
        return xor;
    }
}