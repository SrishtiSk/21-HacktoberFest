//Given an integer x, return true if x is palindrome integer.
public class Solution {
    public bool IsPalindrome(int x) {
        string s = x.ToString();
       // int j;
        bool flag= false;
        if(s[0]=='-')
            return flag;
        for(int i= 0, j=s.Length-1; i<=j; i++, j--){
            if(s[i]==s[j])
              flag=true;
            else return false;
        }
        return flag;
    }
}
