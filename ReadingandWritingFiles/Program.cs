// See https://aka.ms/new-console-template for more information
const string filename = "TestFile.txt";

// TODO: WriteAllText overwrites a file with the given content
if(!File.Exists(filename))
{
    File.WriteAllText(filename, "Hello, World!");
}


// TODO 3: AppendAllText adds text to an existing file

File.AppendAllText(filename, " this text agets appended to the file.");
// TODO 4: A FileStream can be opened and written to until closed

using (StreamWriter sw = File.AppendText(filename))
{
    sw.WriteLine("This is a new line of text.");
    sw.WriteLine("This is another new line of text.");
    sw.WriteLine("This is a third new line of text.");
}
// TODO 2: ReadAllText reads the contents of a file into a string

string content ;
content = File.ReadAllText(filename);

Console.WriteLine(content);