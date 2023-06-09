
#include <vector>
#include <algorithm>
using namespace std;

class Solution {
    
public:
    int findLHS(const vector<int>& nums) const {
        unordered_map<int, int> valueToFrequency;
        int maxSubequence = 0;

        for (int n : nums) {
            ++valueToFrequency[n];

            //C++20: if(valueToFrequency.contains(n - 1))...
            if (valueToFrequency.find(n - 1) != valueToFrequency.end()) {
                maxSubequence = max(maxSubequence, valueToFrequency[n] + valueToFrequency[n - 1]);
            }
            if (valueToFrequency.find(n + 1) != valueToFrequency.end()) {
                maxSubequence = max(maxSubequence, valueToFrequency[n] + valueToFrequency[n + 1]);
            }
        }
        return maxSubequence;
    }
};
