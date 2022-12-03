using DeckPrint;

string [] arrays= {};
 String sdira= "path of the directory";

List<string> files = new List<string>();
String decklist = "path of the directory";

foreach (string d in Directory.GetDirectories(sdira)) {

    foreach (string f in Directory.GetFiles(d, "*.*")) {
       files.Add(f);
    }
}

Console.WriteLine("Please pick a deck or create a new one: ");

Printer loreHold = new Printer();
loreHold.PrintDeck();