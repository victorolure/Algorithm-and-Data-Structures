using System.Text;

bool IsPalindrome(string testString)
{
    StringBuilder sb1 = new StringBuilder();
    StringBuilder sb2 = new StringBuilder();

    bool isPalindrome = false;

    if(!testString.Contains(' '))
    {
        for (int i = 0; i < testString.Length; i++)
        {
            sb1.Append(testString[i]);
        }

        for (int i = testString.Length - 1; i >= 0; i--)
        {
            sb2.Append(testString[i]);
        }

        if (sb1.ToString().ToUpper() == sb2.ToString().ToUpper())
        {
            isPalindrome = true;
        }
        
    }
    return isPalindrome;

}

Console.WriteLine(IsPalindrome("radar"));
Console.WriteLine(IsPalindrome("photo"));
Console.WriteLine(IsPalindrome("racecar"));

char[] DuplicateCharacters(string testString)
{
    char[] testStringChar = testString.ToCharArray();
    List<char> result = new List<char>();
    for(int i = 0; i < testStringChar.Length; i++)
    {
        for(int j = i+1; j < testStringChar.Length; j++)
        {
            if (testStringChar[i] == testStringChar[j])
            {
                result.Add(testStringChar[i]);
        
            }
        }
    }

    return result.ToArray();

}

DuplicateCharacters("Programmatic Python");

for (int i = 0; i < DuplicateCharacters("Programmatic Python").Length; i++)
{
    Console.WriteLine(DuplicateCharacters("Programmatic Python")[i]);
}



    