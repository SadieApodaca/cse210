using System;
using System.IO;

 class Program
{
    static void Main(string[] args)
    {
        Menu myMenu = new Menu();

        Journal myJournal = new Journal();

        JournalEntry myEntry = new JournalEntry();

        int response = 0;

        while(response != 5)
        {
            response = myMenu.ProcessMenu();
            switch(response)
            {
                case 1: 
                    // Call CreateJournalEntry()
                    myJournal.CreateJournalEntry();
                    break;
                case 2: 
                    // Call DisplayJournal()
                    myEntry.DisplayJournalEntry();
                    break;
                case 3: 
                    // Call ReadFromFile()
                    Console.WriteLine("Read");
                    break;
                case 4: 
                    // Call WriteToFile()
                    Console.WriteLine("Write");
                    break;
                
            }
        }
    }
}