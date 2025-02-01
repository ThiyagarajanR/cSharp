﻿// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

string teststr1 = "The quick brown Fox jumps over the lazy Dog";
string teststr2 = "the quick brown fox jumps over the lazy dog";


// TODO: The Is Match function is used to determine if the content of a string
// results in a match with the given Regex

Regex CapWords = new Regex(@"[A-Z]\w+");
Console.WriteLine(CapWords.IsMatch(teststr1));
Console.WriteLine(CapWords.IsMatch(teststr2));

// TODO: The RegexOptions argument can be used to perform case-insensitive searches

Regex NoCase = new Regex(@"fox", RegexOptions.IgnoreCase);

Console.WriteLine(NoCase.IsMatch(teststr1));
Console.WriteLine(NoCase.IsMatch(teststr2));

// Use the Match and Matches methods to get information about 
// Specific Regex matches for a given pattern

// TODO: The Match return single match object at a time
Match m = CapWords.Match(teststr1);

while(m.Success)
{
    Console.WriteLine($"'{m.Value}' found at index {m.Index}");
    m = m.NextMatch();
}

// TODO: The Matches method returns a collection of Match objects

MatchCollection mc = CapWords.Matches(teststr1);

Console.WriteLine($"Found {mc.Count} Matches:");

foreach(Match match in mc)
{
    Console.WriteLine($"'{match.Value}' found at index {match.Index}");
}


