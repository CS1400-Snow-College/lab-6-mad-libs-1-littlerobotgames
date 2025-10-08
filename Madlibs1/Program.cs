//Alex Gardner - Madlibs #1 - 10/7/2025

//Data setup
using System.Diagnostics;

string originalStory = "A vacation is when you take a trip to some (adjective) place with your (adjective) family. " +
    "Usually, you go to some place that is near a/an (noun) or up on a/an (noun). A good vacation place is one where you can ride (plural noun) " +
    "or play (game) or go hunting for (plural noun). I like to spend my time (verb ending in “ing”) or (verb ending in “ing”). " +
    "When parents go on a vacation, they spend their time eating three (plural noun) a day, and fathers play golf, " +
    "and mothers sit around (verb ending in “ing”) Last summer, my little brother fell in a/an (noun) and got poison (plant) " +
    "all over his (part of the body) My family is going to go to (place) and I will practice (verb ending in “ing”) " +
    "Parents need vacations more than kids because parents are always very (adjective) and because they have to work (number) " +
    "hours every day all year making enough (plural noun) to pay for the vacation.";

string[] storyWords = originalStory.Split(' ');
string[] newStory = new string[storyWords.Length];

//Start input
Console.WriteLine("     Welcome to Madlib 1     \n");

for (int i = 0; i < storyWords.Length; i++)
{
    string word = storyWords[i];

    if (word.StartsWith('('))
    {
        string wordType = word;
        while (!storyWords[i].Contains(')'))
        {
            i++;
            wordType += " " + storyWords[i];
        }

        wordType = wordType.Replace("(", "");
        wordType = wordType.Replace(")", "");
        wordType = wordType.Trim();

        bool period = wordType.EndsWith(".");

        if (period)
        {
            wordType = wordType.Replace(".", "");
        }

        Console.Write($"Please give me a/an {wordType}: ");
        string input = Console.ReadLine();

        if (period)
        {
            input += ".";
        }

        newStory[i] = input;
    }
    else
    {
        newStory[i] = storyWords[i];
    }
}

Console.WriteLine("\nHere's your story!\n");

for (int i = 0; i < newStory.Length; i++)
{
    Console.Write($"{newStory[i]} ");
}