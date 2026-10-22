class Scripture
{
    private List<Word> _words;
    //ToDO - Add Scripture Reference

    public Scripture(string bookName, int chapter, int verse, string text)
    {
        _words = ConvertToWordList(text);
    }
    public Scripture(string bookName, int chapter, int startVerse, int endVerse, string text)
    {
        _words = ConvertToWordList(text);
    }
    //Sccripture reference
    public void ShowScripture()
    {
        foreach(Word word in _words)
        {
            word.Display();
        }
    }

    private List<Word> ConvertToWordList(string text)
    {
        List<Word> tempWordList = new List<Word>();
        string[] tempWords = text.Split(' ');
        foreach(string w in tempWords)
        {
            Word tempWord = new Word(w);
            tempWordList.Add(tempWord);
        }
        
        return tempWordList;
    }

}