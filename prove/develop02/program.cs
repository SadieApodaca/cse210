

class Program
{
    static void Main(string[] args)
    {
        Menu myMenu = new Menu();

        JournalEntry myEntry = new JournalEntry();

        int response = 0;

        while(response != 5)
        {
            response = myMenu.ProcessMenu();
            switch(response)
            {
                case 1: 
                    // Call CreateJournalEntry()
                    myEntry.CreateJournalEntry();
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