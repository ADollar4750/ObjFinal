// This is writing the file chosen.
using System.IO;
namespace DeckPrint {
    class Printer {

        public void PrintDeck()
        {
            Console.WriteLine("test");
            using (var reader = new StreamReader(string.Format("DeckFolder/{choice}LoreHold_Legacies.csv", "test")))
            {
                List<string> listA = new List<string>();
                List<string> listB = new List<string>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var vales = line.Split(',');

                    listA.Add(vales[0]);
                    listA.Add(vales[1]);
                    listA.Add(vales[2]);
                    listA.Add(vales[3]);
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
