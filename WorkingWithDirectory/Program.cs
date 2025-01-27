// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

const string dirname = "TestDir";

// TODO: Create a Directory if it doesn't already exist
/*if(!Directory.Exists(dirname))
{
    Directory.CreateDirectory(dirname);
    Console.WriteLine("Directory created");
}
else{
    Directory.Delete(dirname);
    Console.WriteLine("Directory deleted");
}*/


// TODO: Get the path for the current directory

string curPath = Directory.GetCurrentDirectory();
Console.WriteLine($"Current directory is {curPath}");


// TODO: Just like with files, you can retrieve info about a directory

DirectoryInfo di = new DirectoryInfo(dirname);

Console.WriteLine($"Directory Name: {di.Name}");
Console.WriteLine($"Parent Directory Name : {di.Parent}");
Console.WriteLine($"Creation Time: {di.CreationTime}");

// TODO: Enumerate the contents of directories

List<string> thedirsd = new List<string>(Directory.EnumerateDirectories(curPath));

foreach(string dir in thedirsd)
{
    Console.WriteLine(dir);
}

Console.WriteLine("----------");


List<string> thedirsf = new List<string>(Directory.EnumerateFiles(curPath));

foreach(string dir in thedirsf)
{
    Console.WriteLine(dir);
}


Console.WriteLine("----------");

List<string> thedirsE = new List<string>(Directory.EnumerateFileSystemEntries(curPath));

foreach(string dir in thedirsE)
{
    Console.WriteLine(dir);
}


Console.WriteLine("----------");



