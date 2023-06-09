
/**
 * @param {number[]} nums
 * @return {number}
 */
var findLHS = function (nums) {
    const valueToFrequency = new Map();
    let maxSubequence = 0;

    for (let n of nums) {
        valueToFrequency.set(n, (valueToFrequency.get(n) ? valueToFrequency.get(n) : 0) + 1);
        if (valueToFrequency.has(n - 1)) {
            maxSubequence = Math.max(maxSubequence, valueToFrequency.get(n) + valueToFrequency.get(n - 1));
        }
        if (valueToFrequency.has(n + 1)) {
            maxSubequence = Math.max(maxSubequence, valueToFrequency.get(n) + valueToFrequency.get(n + 1));
        }
    }
    return maxSubequence;
};
