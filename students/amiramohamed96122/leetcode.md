## 	URL of your LeetCode account 
https://leetcode.com/u/Amira_Mohamed99/

##  submission
https://https://leetcode.com/submissions/detail/2129608444/

## code
public class Solution 
{
    public void ReverseString(char[] s)
    {
        int left = 0;
        int right = s.Length - 1;

        while (left < right) 
        {
            char temp = s[left];
            s[left] = s[right];
            s[right] = temp;

            // Move pointers closer to the center
            left++;
            right--;
        }
    }
}








