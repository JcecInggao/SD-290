// Lab 1
int userArrayLength = GetNumberInput();
string[] userStringArray = PopulateWordArray(userArrayLength);
char userChar = getCharacterInput();
int charCount = CountCharacters(userStringArray, userChar);
int charFreq = GetCharacterOccurrencePercentage(userStringArray, charCount);

PrintResults(userChar, charCount, charFreq);

int GetNumberInput()
{
    Console.WriteLine("Please enter a number");
    int arrayLength = Int32.Parse(Console.ReadLine());

    return arrayLength;
}

string[] PopulateWordArray(int length)
{
    string[] userStrings = new string[length];
    Console.WriteLine($"Please enter {length} {(length > 1 ? "words" : "word")}: ");
    bool containsSpace = false;

    for (int i = 0; i < length; i++)
    {
        string userStringInput = Console.ReadLine();

        // assume user input contains no spaces
        if (userStringInput.Contains(" "))
        {
            containsSpace = true;
        }
        while (containsSpace)
        {
            Console.WriteLine("Please ensure there are no spaces");
            userStringInput = Console.ReadLine();
            if (userStringInput.Contains(" "))
            {
                containsSpace = true;
            }
            else
            {
                containsSpace = false;
            }
        }

        userStrings[i] = userStringInput.ToLower();
    }

    return userStrings;
}

char getCharacterInput()
{
    bool isChar = false;
    char userChar = ' ';
    while (!isChar)
    {
        Console.WriteLine("Please enter a valid character (letters): ");
        userChar = Console.ReadKey().KeyChar;
        if (Char.IsLetter(userChar))
        {
            isChar = true;
            return userChar;
        }
    }

    // should never be called for
    return userChar;
}

int CountCharacters(string[] words, char charToCount)
{
    int charFreq = 0;
    for (int i = 0; i < words.Length; i++)
    {
        foreach (char c in words[i])
        {
            if (c == (charToCount))
            {
                charFreq++;
            }
        }
    }

    return charFreq;
}

int GetCharacterOccurrencePercentage(string[] words, int charFreq)
{
    int totalChars = 0;
    for (int i = 0; i < words.Length; i++)
    {
        foreach (char c in words[i])
        {
            totalChars++;
        }
    }

    int charPercent = (charFreq * 100 / totalChars);
    return charPercent;
}

void PrintResults(char countedCharacter, int charFrequency, int charPercentage)
{
    Console.WriteLine($"The letter ‘{countedCharacter}’ appears {charFrequency} times in the array. This letter makes up more than {charPercentage}% of the total number of characters.");

}



