
int GetNumberInput()
{
    Console.WriteLine("Please input a number");
    int Input = Int32.Parse(Console.ReadLine());

    return Input;
}

char GetCharacterInput()
{
    Console.WriteLine("Please enter a character");
    char Input = Console.ReadKey().KeyChar;

    return Input;
}

string[] PopulateWordArray(int inputNumber)
{
    Console.WriteLine("Please input your strings");
    string[] wordArray = new string[inputNumber];

    for (int i = 0; i < wordArray.Length; i++)
    {
        wordArray[i] = Console.ReadLine();
    }

    return wordArray;
}

int CountCharacters(string[] words, char charToCount)
{
    int count = 0;
    int totalCharacterCount = 0;
    for (int i = 0; i < words.Length; i++)
    {
        totalCharacterCount += words[i].Length;
        for (int j = 0; j < words[i].Length; j++)
        {
            if (words[i][j] == charToCount)
            {
                count++;
            }
        }

    }
    return count;

}

int GetCharacterOccurencePercentage(string[] words, char charToCount)
{
    int count = 0;
    int totalCharacterCount = 0;
    for (int i = 0; i < words.Length; i++)
    {
        totalCharacterCount += words[i].Length;
        for (int j = 0; j < words[i].Length; j++)
        {
            if (words[i][j] == charToCount)
            {
                count++;
            }
        }

    }
    return (int)((double)count / (double)totalCharacterCount * 100);
}

int GetTotalChars(string[] wordArray)
{
    int count = 0;
    for (int i = 0; i < wordArray.Length; i++)
    {
        count += wordArray[i].Length;
    }
    return count;
}

int numberInput = GetNumberInput();
string[] wordArray = PopulateWordArray(numberInput);
char countedCharacter = GetCharacterInput();
int charFrequency = CountCharacters(wordArray, countedCharacter);
int charPercentage = GetCharacterOccurencePercentage(wordArray, countedCharacter);
int totalChars = GetTotalChars(wordArray);


void PrintResults(char countedCharacter, int charFrequency, int charPercentage, int totalChars)
{

    Console.WriteLine($"\nThe letter {countedCharacter} appears {charFrequency} time{(charFrequency > 1 ? 's' : "")} in the array. {(charPercentage > 25 ? "This letter makes up more than 25% of the total number of characters." : "")}");
}

PrintResults(countedCharacter, charFrequency, charPercentage, totalChars);
