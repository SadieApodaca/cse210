using System;

class Program
{
    static void Main(string[] args)
    {
        Word myWord = new Word("Secret");

        Scripture myScripture = new Scripture("Moses", 1, 39, "For behold, this is my work and my glory- to bring to pass the immortality and eternal life of man.");

        myScripture.ShowScripture();

    }
}
