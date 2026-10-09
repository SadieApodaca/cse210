using System;
using System.IO;

class Program
{

    static void Main(string[] args)
    {
        int[] validNumbers = { 1, 2, 3, 4, 5 };
        int action = 0;
        Console.Write(" Welcome to your journal. ");
        Journal journal = new Journal();
        JournalPrompt jp = new JournalPrompt();

        while (action != 5)
        {
            action = Menu();

            switch (action)
            {
                case 1:
                    // Write Journal Entry
                    string dateInfo = GetDateTime();
                    string prompt = jp.GetPrompt();

                    JournalEntry entry = new JournalEntry();
                    entry._dateTime = dateInfo;
                    entry._journalPrompt = prompt;

                    Console.Write($"{prompt}\n");
                    Console.Write("Type response here: ");
                    string userEntry = Console.ReadLine();
                    entry._journalEntry = userEntry;

                    journal._journal.Add(entry);
                    break;
                case 2:
                    // Display Journal Entries
                    journal.Display();
                    break;
                case 3:
                    // Load text file
                    journal.LoadJournalFile();
                    break;
                case 4:
                    // Save to text file
                    journal.CreateJournalFile();
                    break;
                case 5:
                    // Quit
                    Console.WriteLine("\n Awesome journal entry! Have a good night. \n");
                    break;
            }
        }
    }

    static int Menu()
    {
        string options = @"
Please select one of the following choices:
1. Write a journal entry
2. Display all journal entries
3. Load a file
4. Save to a file
5. Quit

>  ";

        Console.Write(options);
        string userInput = Console.ReadLine();
        int action = 0;
        action = int.Parse(userInput);
        return action;
    }

    static string GetDateTime()
    {
        DateTime now = DateTime.Now;
        string currentDateTime = now.ToString("F");
        return currentDateTime;
    }
    static void AddJournalEntry()
    {
        string MyJournalFile = "MyJournal.txt";
        File.AppendAllText(MyJournalFile, "");
    }


}