string[] englishWords = File.ReadAllLines("english.txt");
string[] portugueseWords = File.ReadAllLines("portuguese.txt");
int[] score1 = new int[englishWords.Length];
int[] score2 = new int[englishWords.Length];
int[] score3 = new int[englishWords.Length];
int[] score4 = new int[englishWords.Length];
int[] score5 = new int[englishWords.Length];
List<Verb> allVerbs = new List<Verb>();
Initialize();

foreach (var v in allVerbs)
{
    Console.WriteLine(v);
}


System.Console.WriteLine(portugueseWords[80] + "\t" + englishWords[80]);

void Initialize()
{
    for (int i = 0 ; i < englishWords.Length ; i++)
    {
        score1[i] = 0 ;
        score2[i] = 0 ;
        score3[i] = 0 ;
        score4[i] = 0 ;
        score5[i] = 0 ;

        Verb verb = new Verb(portugueseWords[i], englishWords[i]);
        allVerbs.Add(verb);
    }
}