
using System;
using System.Collections.Generic;

public class Solution
{
    public int FindLHS(int[] nums)
    {
        var valueToFrequency = new Dictionary<int, int>();
        int maxSubequence = 0;

        foreach (var n in nums)
        {
            if (!valueToFrequency.ContainsKey(n))
            {
                valueToFrequency.Add(n, 0);
            }
            ++valueToFrequency[n];

            if (valueToFrequency.ContainsKey(n - 1))
            {
                maxSubequence = Math.Max(maxSubequence, valueToFrequency[n] + valueToFrequency[n - 1]);
            }
            if (valueToFrequency.ContainsKey(n + 1))
            {
                maxSubequence = Math.Max(maxSubequence, valueToFrequency[n] + valueToFrequency[n + 1]);
            }
        }
        return maxSubequence;
    }
}
