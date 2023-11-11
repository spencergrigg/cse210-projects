using System.IO;
public class Journal
        {
                public List<Entry> _entries = new List<Entry>();

                public void AddEntry(Entry newEntry)
                {
                        _entries.Add(newEntry)
                }
                public void DisplayAll()
                {

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
                } 
                public void SaveToFile(string file)
                {
                    
                    Console.Out.WriteLine("What is the name of the file you would like to write to?");
                    string fileName = (Console.ReadLine());

                    using (StreamWriter outputFile = new StreamWriter(fileName))
                        {
                            // You can add text to the file with the WriteLine method
                            outputFile.WriteLine("This will be the first line in the file.");
                            
                            // You can use the $ and include variables just like with Console.WriteLine
                            string color = "Blue";
                            outputFile.WriteLine($"My favorite color is {color}");
                        }
                }

                public void LoadFromFile(string file)
                {
                    Console.Out.WriteLine("What is the name of the file you would like to load from?");
                    string fileName = (Console.ReadLine());
                    string[] lines = System.IO.File.ReadAllLines(fileName);

                    foreach (string line in lines)
                        {
                            string[] parts = line.Split("\n");

                            string firstName = parts[0];
                            Console.WriteLine($"{line}");
                        }
                }
                

        }
