using System.Collections.Generic; 

namespace DayOne;

public class Program {

    public static IList<int> MajorityElement(int[] nums) {
        /*Size of Array*/
        Dictionary <int, int> number_freq = new Dictionary<int,int>();
        IList<int> magic = new List<int>();
        
        int size = nums.Length;
        int n = size/3;

        foreach (var num in nums)
        {
            if(number_freq.ContainsKey(num)) {
                number_freq[num]++;
            } else {
                number_freq[num] = 1;
            }
        }
        /* Iterate through the frequency */
        foreach (var number in number_freq)
        {  
            if (number.Value > n)
            {
                magic.Add(number.Key);
            }
        }
        return magic;
    }
    static void Main(){
        int[] nums = {1, 2, 3, 3};
        var response = MajorityElement(nums);
    }
}