public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int i = nums.Length/2;
        var previous = nums.Lenght-1;
        while(true) {
            if(nums[i] == target) return i;
            if(nums[i] < target) i
                previous = i;
        }
    }
}