using System.Text.RegularExpressions;

string teststr1 = "The quick brown Fox jumps over the lazy Dog";
string teststr2 = "the quick brown fox jumps over the lazy dog";


// TODO: The Is Match function is used to determine if the content of a string
// results in a match with the given Regex

Regex CapWords = new Regex(@"[A-Z]\w+");

// TODO: Regular Expresson can be used to replace content in a string

string result = CapWords.Replace(teststr1, "---");

Console.WriteLine(result);

// TODO: Replacement Text can be generated on the fly using a MatchEvaluator

// This is a delegate that computes the new value of the replacement

string Makeup(Match m)
{
    string s = m.ToString();
    if(m.Index == 0)
    {
        return s;
    }
    
    return s.ToUpper();
}

string results = CapWords.Replace(teststr1, new MatchEvaluator(Makeup));

Console.WriteLine(teststr1);
Console.WriteLine(results);
