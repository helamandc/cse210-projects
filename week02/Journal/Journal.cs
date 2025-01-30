using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public Journal()
    {
    }

    public void AddEntry(Entry journalEntry)
    {
        _entries.Add(journalEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry e in _entries)
        {
            e.Display();
        }
    }

    public void SaveToFile(string fileNameSave)
    {
        string filePath = $"C:\\Users\\manle\\Desktop\\{fileNameSave}";

        try
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (Entry entry in _entries)
                {
                    writer.WriteLine(entry.ToString());
                }
            }
        }
        //Exceeding requirements by adding an exception if for it failed to load from file
        catch (Exception e)
        {
            Console.WriteLine($"An error occurred: {e.Message}");
        }
    }

    public void LoadFromFile(string fileNameLoad)
    {
        string filePath = $"C:\\Users\\manle\\Desktop\\{fileNameLoad}";

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
        //Exceeding requirements by adding an exception if for it failed to load from file
        catch (Exception e)
        {
            Console.WriteLine($"An error occurred: {e.Message}");
        }
    }

}