using System.Security.Cryptography;

string[] englishWords = File.ReadAllLines("english.txt");
string[] portugueseWords = File.ReadAllLines("portuguese.txt");
string[] ele = File.ReadAllLines("ele_ela.txt");
string[] eles = File.ReadAllLines("eles_elas.txt");
string[] eu = File.ReadAllLines("eu.txt");
string[] nos = File.ReadAllLines("nos.txt");
string[] voce = File.ReadAllLines("voce.txt");
string[] voces = File.ReadAllLines("voces.txt");

string[] eleEn = File.ReadAllLines("ele_ela_en.txt");
string[] elesEn = File.ReadAllLines("eles_elas_en.txt");
string[] euEn = File.ReadAllLines("eu_en.txt");
string[] nosEn = File.ReadAllLines("nos_en.txt");
string[] voceEn = File.ReadAllLines("voce_en.txt");
string[] vocesEn = File.ReadAllLines("voces_en.txt");

string[] formatPT = {"Eu","Você", "Ele", "Ela", "Eles", "Elas", "Nos", "Vocês"};
string[] formatEN = {"I","You (singular)", "He", "She", "They", "They (females)", "We", "You (plural)"};
// formatPT[0] = Eu
// formatPT[0] = Você
// formatPT[0] = Ele
// formatPT[0] = Ela
// formatPT[0] = Eles
// formatPT[0] = Elas
// formatPT[0] = Nos
// formatPT[0] = Vocês


int[] score1 = new int[englishWords.Length];
int[] score2 = new int[englishWords.Length];
int[] score3 = new int[englishWords.Length];
int[] score4 = new int[englishWords.Length];
int[] score5 = new int[englishWords.Length];
List<Verb> allVerbs = new List<Verb>();
Initialize();

for (int i = 0; i < englishWords.Length ; i++)
{
    
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
        
    }
}