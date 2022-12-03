using DeckPrint;

var files = new List<string>(); 
string sdira= "path of the directory"; 
foreach (string d in Directory.GetDirectories(sdira)) {   
    files.AddRange(Directory.GetFiles(d, "*.*"));   
}

// To use
foreach(string file in files) { }
string file2 = files[2]; 
// or convert to array
string[] arrays = files.ToArray();

Console.WriteLine("Please pick a deck or create a new one: ");


Printer loreHold = new Printer();
loreHold.PrintDeck();