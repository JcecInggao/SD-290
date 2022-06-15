// Lab 1

// ---------------- Check array Phase ----------------

Console.WriteLine("Please enter a number");
int arrayLength = Int32.Parse(Console.ReadLine());
string[] userStrings = new string[arrayLength];

// ---------------- Check string Phase ----------------
Console.WriteLine($"Please enter {arrayLength} {(arrayLength > 1 ? "words" : "word")}: ");
// loop through the whole array

bool containsSpace = false;


for (int i = 0; i < arrayLength; i++)
{
    // user inputs string into array
    string userStringInput = Console.ReadLine();

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

// ---------------- Check character Phase ----------------
bool isChar = false;
Console.WriteLine("Please enter a character: ");
char userChar = Console.ReadKey().KeyChar;
if (Char.IsLetter(userChar))
{
    isChar = true;
}

while (!isChar)
{
    Console.WriteLine("Please enter a valid character (letters): ");
    userChar = Console.ReadKey().KeyChar;
    if (Char.IsLetter(userChar))
    {
        isChar = true;
    }
}
Console.WriteLine("");

// ---------------- Check frequency Phase ----------------
int totalChars = 0;
int charFreq = 0;
for (int i = 0; i < arrayLength; i++)
{
    foreach (char c in userStrings[i])
    {
        totalChars++;
        if (c == (userChar))
        {
            charFreq++;
        }
    }
}

int charPercent = (charFreq * 100 / totalChars);
Console.WriteLine($"The letter ‘{userChar}’ appears {charFreq} times in the array. This letter makes up more than {charPercent}% of the total number of characters.");
