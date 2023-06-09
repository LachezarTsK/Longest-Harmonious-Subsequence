
import java.util.Map;
import java.util.HashMap;

public class Solution {

    public int findLHS(int[] nums) {
        Map<Integer, Integer> valueToFrequency = new HashMap<>();
        int maxSubequence = 0;

        for (int n : nums) {
            valueToFrequency.put(n, valueToFrequency.getOrDefault(n, 0) + 1);
            if (valueToFrequency.containsKey(n - 1)) {
                maxSubequence = Math.max(maxSubequence, valueToFrequency.get(n) + valueToFrequency.get(n - 1));
            }
            if (valueToFrequency.containsKey(n + 1)) {
                maxSubequence = Math.max(maxSubequence, valueToFrequency.get(n) + valueToFrequency.get(n + 1));
            }
        }
        return maxSubequence;
    }
}
