using System;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
{
    using (StreamWriter writer = new StreamWriter(file))
    {
        foreach (var entry in _entries)
        {
            writer.WriteLine($"\"{entry.Date}\",\"{entry.PromptText.Replace("\"", "\"\"")}\",\"{entry.EntryText.Replace("\"", "\"\"")}\"");
        }
    }
}

public void LoadFromFile(string file)
{
    _entries.Clear();
    using (StreamReader reader = new StreamReader(file))
    {
        string line;
        while ((line = reader.ReadLine()) != null)
        {
            var parts = line.Split(new[] { "\",\"" }, StringSplitOptions.None);
            _entries.Add(new Entry { Date = DateTime.Parse(parts[0].Trim('\"')), PromptText = parts[1], EntryText = parts[2].Trim('\"') });
        }
    }
}
        }
    


