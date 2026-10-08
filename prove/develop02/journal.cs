
class Journal
{
    public List<JournalEntry> _entries = newList<JournalEntry>();

    public void DisplayJournal()
    {
        foreach(JournalEntry entry in _entires)
        {
            entry.DisplayJournalEntry();
        }
    }

    public void CreateJournalEntry()
    {
        JournalEntry newEntry = new JournalEntry();
        newEntry.CreateJournalEntry();
        _entries.Add(newEntry);
    }
}















// public void WriteToFile(string journal.csv)
// {
//     string[] lines = System.IO.File.ReadAllLines(journal.csv)
// }