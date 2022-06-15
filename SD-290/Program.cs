// Lab 3

string palindrome = "rAcecaR";
string nonPalindrome = "palindrome";

Console.WriteLine(IsPalindrome(palindrome));
Console.WriteLine(IsPalindrome(nonPalindrome));

string duplicates = "ProgRaMmatic Python";
Console.WriteLine(DuplicateCharacters(duplicates));

bool IsPalindrome(string testString)
{
    if (testString.Contains(" "))
    {
        Console.WriteLine($"The inputed word contains a space: {testString}");
        return false;
    }

    testString = testString.ToLower();
    bool isPalindrome = false;

    // break down string into a char array
    char[] pTester = testString.ToCharArray();

    // reverse char array
    Array.Reverse(pTester);

    // rejoin reversed char array back to string
    string checkString = new string(pTester);

    // check if reversed string is identical to original string
    if (checkString == testString)
    {
        isPalindrome = true;
    }

    return isPalindrome;
}


char[] DuplicateCharacters(string testString)
{
    // break down string to char array first
    char[] dupeChars = testString.ToLower().ToCharArray();
    char[] dupeArray = new char[dupeChars.Length];

    // loops through entire array
    for (int outerIndex = 0; outerIndex < dupeChars.Length; outerIndex++)
    {
        // checks all the letters after the current letter
        for (int innerIndex = outerIndex + 1; innerIndex < dupeChars.Length; innerIndex++)
        {
            // if a character is identical
            if (dupeChars[outerIndex] == dupeChars[innerIndex])
            {
                // increase array size
                Array.Resize(ref dupeArray, dupeArray.Length + 1);
                // add identical letter to array
                dupeArray[dupeArray.Length - 1] = dupeChars[outerIndex];
            }
        }
    }

    return dupeArray;
}