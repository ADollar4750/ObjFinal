// The excel file was put in on accedent I realized it would be easier to conveter it to a cvs file instead.
using System.IO;
namespace DeckPrint {
    class Printer {

        public void PrintDeck()
        {
            Console.WriteLine("test");
            using (var reader = new StreamReader("LoreHold_Legacies.csv"))
            {
                List<string> listA = new List<string>();
                List<string> listB = new List<string>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var vales = line.Split(',');

                    listA.Add(vales[0]);
                    listA.Add(vales[1]);
                }
                for (int i = 0; i < listA.Count; i++)
                {
                    Console.WriteLine(listA[i]);
                }
                for (int i = 0; i < listB.Count; i++)
                {
                    Console.WriteLine(listB[i]);
                }
            }
        }
    }

}
