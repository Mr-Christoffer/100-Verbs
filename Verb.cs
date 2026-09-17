class Verb
{
    public string EnglishWord = "";
    public string PortugueseWord = "";


    

    // Contructor - runs automatically when we write new Course
    public Verb(string ptWord, string enWord)
    {
        EnglishWord = enWord;
        PortugueseWord = ptWord;
    }
}