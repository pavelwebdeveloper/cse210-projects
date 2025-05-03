using System;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach(Entry entry in _entries)
        {
            entry.ShowEntry();
            Console.WriteLine();
        }
    }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            for(int i = 0; i < _entries.Count; i++)
            {                
                    outputFile.WriteLine(_entries[i]._date);
                    outputFile.WriteLine(_entries[i]._prompt);
                    outputFile.WriteLine(_entries[i]._text);
            }
        }
    }

    public void LoadFromFile(string fileName)
    {
        string[] lines = System.IO.File.ReadAllLines(fileName);

        for(int i = 0; i < lines.Length; i++)
        {
            if(i == 0 || i % 3 == 0)
            {
                Entry entry = new Entry();
                entry._date = lines[i++];
                entry._prompt = lines[i++];
                entry._text = lines[i];
                _entries.Add(entry);
            }
        }
    }

}