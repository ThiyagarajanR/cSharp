// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string teststr = "The quick brown Fox jumps over the lazy Dog";

//TODO: Contains determines whether a string contains certain content

Console.WriteLine($"{teststr.Contains("fox")}");
Console.WriteLine($"{teststr.Contains("fox",StringComparison.CurrentCultureIgnoreCase)}");

//TODO: StartsWith and EndsWith determine if a string starts
// or ends with a given test string

Console.WriteLine($"{teststr.StartsWith("the")}");
Console.WriteLine($"{teststr.StartsWith("the",StringComparison.CurrentCultureIgnoreCase)}");
Console.WriteLine($"{teststr.EndsWith("dog")}");
Console.WriteLine($"{teststr.EndsWith("dog",StringComparison.CurrentCultureIgnoreCase)}");


//TODO: IndexOf, LastIndexOf finds the index of a substring

Console.WriteLine($"{teststr.IndexOf("the")}");
Console.WriteLine($"{teststr.LastIndexOf("the")}");

Console.WriteLine($"{teststr.IndexOf("the",StringComparison.CurrentCultureIgnoreCase)}");
Console.WriteLine($"{teststr.LastIndexOf("the",StringComparison.CurrentCultureIgnoreCase)}");


// TODO: Determining empty, null, or whitespace

string str1 = null;
string str2 = "  ";
string str3 = string.Empty;

Console.WriteLine($"{string.IsNullOrEmpty(str1)}");
Console.WriteLine($"{string.IsNullOrEmpty(str3)}");
Console.WriteLine($"{string.IsNullOrWhiteSpace(str2)}");


how to convert a datetime(2030,4,1)
 into to string 2030-04-01
DateTime date = new DateTime(2030, 4, 1);
string formattedDate = date.ToString("yyyy-MM-dd");
Console.WriteLine(formattedDate);

