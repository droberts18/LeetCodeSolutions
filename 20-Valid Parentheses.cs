/*
Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

An input string is valid if:

Open brackets must be closed by the same type of brackets.
Open brackets must be closed in the correct order.
Note that an empty string is also considered valid.
*/


// Time Complexity: O(n)
// Runtime: 80ms
// Memory: 20.1 MB

public class Solution {
    public bool IsValid(string s) {

        Dictionary<Char, Char> brackets = new Dictionary<Char, Char>();
        brackets.Add(')', '(');
        brackets.Add(']', '[');
        brackets.Add('}', '{');

        // initializing stack
        Stack<Char> bracketStk = new Stack<Char>();

        for(int i = 0; i < s.Length; i++){
            if(brackets.ContainsKey(s[i])){
                if(bracketStk.Count == 0)
                    return false;

                Char topStack = bracketStk.Pop();
                if(topStack != brackets[s[i]])
                    return false;
            }
            else{
                bracketStk.Push(s[i]);
            }
        }
        
        return bracketStk.Count == 0;
    }
}