using System;

public class JournalPrompt
{

    public static string[] _prompt = {
        "What was the best part of your day?",
            "What habits help you feel grounded?",
            "What questions do you have right now?",
            "How did you see the hand of the Lord in your life today?",
            "What was your most spiritual experience today?",
            "If you could do one thing over today, what would it be?",
            "What was the best idea you had today?",
            "List the 3 things you are grateful for today and why.",
            "What was the best meal of the day today and what was it?",
            "Who made you feel good today?",
            "What made you feel sad today?",
            "What is the best thing you learned today?",
            "What is the funniest thing that happened today?",
            "What is something you would like to learn more about?",
            "What is something you really want to buy, but won't?",
            "How productive was your day today?",
            "What scripture have you been pondering lately?",
            "What hymn is stuck in your head?",
            "What is something that made you laugh today?",
            "Who made your day better today?",
            "What is something you want to remember from today?",
            "What steps did you take today towards a goal you are working on?",
            "What could you do to make tomorrow a better day?",
            "What is something that went well today?",
            "What is a simple pleasure in your life that you are thankful for?",
            "How did you show love to someone today?",
            "How did you feel the spirit today?",
            "What challenges did you face today?",
            "What do I need to let go of today?",
            "What do you need the most right now?",
            "What goals do you want to set for tomorrow?",
            "What was the most peaceful moment of your day?",
            "Would you change any of the decisions you made today?",
            "What scared you today?",
            "What worried you today?",
            "Who do you wish you had talked to today? What would you say?",
            "How does your body feel today?",
            "Did you read a book today?",
            "Did you watch a movie today?",
            "Did you watch a TV show today?"
    };
    public List<string> _journalPrompt = new List<string>(_prompt);

    public JournalPrompt()
    {

    }

    public void Display()
    {
        var random = new Random();
        int index = random.Next(_journalPrompt.Count);
        string journalPrompt = _journalPrompt[index];
        Console.WriteLine($"\n{_journalPrompt}");
    }

    public string GetPrompt()
    {
        var random = new Random();
        int index = random.Next(_journalPrompt.Count);
        string journalPrompt = _journalPrompt[index];
        
        return journalPrompt;
    }
}