public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            //organized what will be shown when entry is written
            Console.WriteLine($"{entry.Date}: {entry.Prompt} - {entry.Response}");
        }
    }

//save to file and add date
    public void SaveToFile()
    {
        const string filePath = "entries.txt";
        try
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (Entry entry in _entries)
                {
                    writer.WriteLine($"{entry.Date.ToString("yyyy-MM-dd HH:mm:ss")}: {entry.Prompt} - {entry.Response}");
                }
            }

            Console.WriteLine($"Journal saved to {filePath}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving journal to file: {ex.Message}");
        }
    }

//load from file entries.txt
    public void LoadFromFile()
    {
        const string filePath = "entries.txt";

        try
        {
            string[] lines = File.ReadAllLines(filePath);

            _entries.Clear();

            foreach (string line in lines)
            {
                string[] parts = line.Split(new char[] { ':' }, 3);
                string dateString = parts[0].Trim();
                DateTime date;

                if (DateTime.TryParse(dateString, out date))
                {
                    string promptResponse = parts[1].Trim();
                    string response = parts[2].Trim();

                    Entry loadedEntry = new Entry { Date = date, Prompt = promptResponse, Response = response };
                    _entries.Add(loadedEntry);
                }
                else
                {
                    Console.WriteLine($"Invalid date format: {dateString}");
                }
            }

            Console.WriteLine($"Journal loaded from {filePath}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading journal from file: {ex.Message}");
        }
    }
}