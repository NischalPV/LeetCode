namespace ransom_note;

// Given two strings ransomNote and magazine, return true if ransomNote can be constructed by using the letters from magazine and false otherwise.

// Each letter in magazine can only be used once in ransomNote.

 

// Example 1:

// Input: ransomNote = "a", magazine = "b"
// Output: false
// Example 2:

// Input: ransomNote = "aa", magazine = "ab"
// Output: false
// Example 3:

// Input: ransomNote = "aa", magazine = "aab"
// Output: true
 

// Constraints:

// 1 <= ransomNote.length, magazine.length <= 105
// ransomNote and magazine consist of lowercase English letters.

class Program
{
    static void Main(string[] args)
    {

        string ransomNote = "a";
        string magazine = "b";

        var result = CanConstruct(ransomNote, magazine);

        Console.WriteLine(result);
    }

    public static bool CanConstruct(string ransomNote, string magazine)
    {
        Dictionary<char, int> ransomNoteDictionary = new Dictionary<char, int>();
        Dictionary<char, int> magazineDictionary = new Dictionary<char, int>();

        foreach (char c in ransomNote)
        {
            if (ransomNoteDictionary.ContainsKey(c))
            {
                ransomNoteDictionary[c]++;
            }
            else
            {
                ransomNoteDictionary.Add(c, 1);
            }
        }

        foreach (char c in magazine)
        {
            if (magazineDictionary.ContainsKey(c))
            {
                magazineDictionary[c]++;
            }
            else
            {
                magazineDictionary.Add(c, 1);
            }
        }

        foreach (var item in ransomNoteDictionary)
        {
            if (!magazineDictionary.ContainsKey(item.Key))
            {
                return false;
            }
            else
            {
                if (magazineDictionary[item.Key] < item.Value)
                {
                    return false;
                }
            }
        }

        return true;
    }
}
