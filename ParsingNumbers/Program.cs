// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] Numstrs = {" 1 ", " 1.45 ", "-100", "5e+04 "};

int testint;
float testfloat;
bool result;

//TODO: The Parse method attempts to parse a string to a number and
// throws an exception if the parse is unsuccessful

foreach(string str in Numstrs)
{
    try{
        testfloat = float.Parse(str);
        Console.WriteLine($"Parsed number is {testfloat}");
        testint = int.Parse(str);
        Console.WriteLine($"Parsed number is  {testint}");
    }
    catch(FormatException e)
    {
        Console.WriteLine($"could not parse '{str}': {e.Message}");
    }
}

//TODO: The TryParse method attempts to parse a string to a number and

foreach(string str in Numstrs)
{
    result = float.TryParse(str, out testfloat);
    Console.WriteLine($"{result} -- '{str}' : {testfloat}");
    
    result = int.TryParse(str, out testint);
    Console.WriteLine($"{result} -- '{str}' : {testint}");
}

