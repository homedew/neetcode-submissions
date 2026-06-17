public class Solution {
    public int FindMin(int[] nums) {
        int left = 0 , right = nums.Length - 1;

        while(left < right) {
            int mid = left + ( right  - left) /2;

            if(nums[mid] < nums[right]) {
                right = mid ;
            } else {
                left = mid + 1;
            }
        }

        return nums[left];
    }
}

// //[4,5,0,1,2,3]
// // mid = 2
// nums[5] < nums[2] => 3 < 0
// left = 3
// right = 5

// mid = 4
// nums[3] < nums[]