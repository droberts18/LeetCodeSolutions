/*
Given an array of integers, return indices of the two numbers such that they add up to a specific target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

Example:

Given nums = [2, 7, 11, 15], target = 9,

Because nums[0] + nums[1] = 2 + 7 = 9,
return [0, 1].
*/


// Time Complexity: O(n)
// Runtime: 264ms
// Memory: 29.2 MB

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++){
            if(!dict.ContainsKey(nums[i])){
                dict.Add(nums[i], i);
            }
            int complement = target - nums[i];
            
            if(dict.ContainsKey(complement) && dict[complement] != i){
                return new int[]{dict[complement], i};
            }
        }
        throw new System.ArgumentException ("No two numbers add to the specified target.");
    }
}

// Time Complexity: O(n^2)
// Runtime: 392ms
// Memory: 28.8 MB

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int complement;
        int[] answer = {0, 0};
        
        for(int i = 0; i < nums.Length-1; i++){
            complement = target - nums[i];
            
            for(int j = i+1; j < nums.Length; j++){
                if(nums[j] == complement){
                    answer[0] = i;
                    answer[1] = j;
                    return answer;
                }
            }
        }
        throw new System.ArgumentException ("No two numbers add to the specified target.");
    }
}