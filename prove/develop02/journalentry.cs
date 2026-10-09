using System;

public class JournalEntry
{
    public string _dateTime = "";
    public string _journalPrompt = "";
    public string _journalEntry = "";
    public string _journalFile = "";


    public JournalEntry()
    {
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_dateTime}");
        Console.WriteLine($"Prompt: {_journalPrompt}");
        Console.WriteLine($"Response: {_journalEntry} \n");
    }

}