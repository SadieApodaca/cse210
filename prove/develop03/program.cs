using System;

class Program
{
    static void Main(string[] args)
    {

        ScriptureLibrary library = new ScriptureLibrary();

        library.AddScripture(new Reference("2 Nephi", 31, 19), "And now, my beloved brethren, after ye have gotten into this strait and narrow path, I would ask if all is done? Behold, I say unto you, Nay; for ye have not come thus far save it were by the word of Christ with unshaken faith in him, relying wholly upon the merits of him who is mighty to save.");
        library.AddScripture(new Reference("Doctrine and Covenants", 1, 30), "And also those to whom these commandments were given, might have power to lay the foundation of this church, and to bring it forth out of obscurity and out of darkness, the only true and living church upon the face of the whole earth, with which I, the Lord, am well pleased, speaking unto the church collectively and not individually—");
        library.AddScripture(new Reference("1 Nephi", 6, 4), "For the fulness of mine intent is that I may persuade men to come unto the God of Abraham, and the God of Isaac, and the God of Jacob, and be saved.");
        library.AddScripture(new Reference("Alma", 30, 44), "But Alma said unto him: Thou hast had signs enough; will ye tempt your God? Will ye say, Show unto me a sign, when ye have the testimony of all these thy brethren, and also all the holy prophets? The scriptures are laid before thee, yea, and all things denote there is a God; yea, even the earth, and all things that are upon the face of it, yea, and its motion, yea, and also all the planets which move in their regular form do witness that there is a Supreme Creator.");
        library.AddScripture(new Reference("2 Nephi", 32, 9), "But behold, I say unto you that ye must pray always, and not faint; that ye must not perform any thing unto the Lord save in the first place ye shall pray unto the Father in the name of Christ, that he will consecrate thy performance unto thee, that thy performance may be for the welfare of thy soul.");
        library.AddScripture(new Reference("Moroni", 7, 33), "And Christ hath said: If ye will have faith in me ye shall have power to do whatsoever thing is expedient in me.");
        library.AddScripture(new Reference("3 Nephi", 9, 13, 14), "O all ye that are spared because ye were more righteous than they, will ye not now return unto me, and repent of your sins, and be converted, that I may heal you? Yea, verily I say unto you, if ye will come unto me ye shall have eternal life. Behold, mine arm of mercy is extended towards you, and whosoever will come, him will I receive; and blessed are those who come unto me.");
        library.AddScripture(new Reference("Doctrine and Covenants", 64, 9, 10), "Wherefore, I say unto you, that ye ought to forgive one another; for he that forgiveth not his brother his trespasses standeth condemned before the Lord; for there remaineth in him the greater sin. I, the Lord, will forgive whom I will forgive, but of you it is required to forgive all men.");
        library.AddScripture(new Reference("Alma", 26, 14, 15), "Yea, we have reason to praise him forever, for he is the Most High God, and has loosed our brethren from the chains of hell. Yea, they were encircled about with everlasting darkness and destruction; but behold, he has brought them into his everlasting light, yea, into everlasting salvation; and they are encircled about with the matchless bounty of his love; yea, and we have been instruments in his hands of doing this great and marvelous work.");
            

        while (true)
        {
            Console.Clear();
            Scripture scripture = library.SelectRandomScripture();
            Console.WriteLine();

            while (!scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.RenderScripture());
                
                

                Console.WriteLine("\n Press enter to continue or type 'quit' to finish:");
                string input = Console.ReadLine();
                if (input.ToLower() == "quit")
                    {
                        break;
                    }
                

                scripture.HideRandom();  
                if (scripture.IsCompletelyHidden())
                    {
                        break;
                    }
            }
            if (scripture.IsCompletelyHidden())
                    {
                        break;
                    }
            
        }
        
    


    }


}
