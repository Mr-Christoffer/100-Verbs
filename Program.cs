using System.Globalization;

string[] englishWords = File.ReadAllLines("english.txt");
string[] portugueseWords = File.ReadAllLines("portuguese.txt");
string[] ele = File.ReadAllLines("ele_ela.txt");
string[] eles = File.ReadAllLines("eles_elas.txt");
string[] eu = File.ReadAllLines("eu.txt");
string[] nos = File.ReadAllLines("nos.txt");
string[] voce = File.ReadAllLines("você.txt");
string[] voces = File.ReadAllLines("vocês.txt");

string[] eleEn = File.ReadAllLines("ele_ela_en.txt");
string[] elesEn = File.ReadAllLines("eles_elas_en.txt");
string[] euEn = File.ReadAllLines("eu_en.txt");
string[] nosEn = File.ReadAllLines("nos_en.txt");
string[] voceEn = File.ReadAllLines("voce_en.txt");
string[] vocesEn = File.ReadAllLines("voces_en.txt");

int[] euScore1 = new int[englishWords.Length];
int[] euScore2 = new int[englishWords.Length];
int[] euScore3 = new int[englishWords.Length];
int[] euScore4 = new int[englishWords.Length];
int[] euScore5 = new int[englishWords.Length];
double[] euAvScore = new double[englishWords.Length];

int[] voceScore1 = new int[englishWords.Length];
int[] voceScore2 = new int[englishWords.Length];
int[] voceScore3 = new int[englishWords.Length];
int[] voceScore4 = new int[englishWords.Length];
int[] voceScore5 = new int[englishWords.Length];
double[] voceAvScore = new double[englishWords.Length];

int[] eleScore1 = new int[englishWords.Length];
int[] eleScore2 = new int[englishWords.Length];
int[] eleScore3 = new int[englishWords.Length];
int[] eleScore4 = new int[englishWords.Length];
int[] eleScore5 = new int[englishWords.Length];
double[] eleAvScore = new double[englishWords.Length];

int[] elesScore1 = new int[englishWords.Length];
int[] elesScore2 = new int[englishWords.Length];
int[] elesScore3 = new int[englishWords.Length];
int[] elesScore4 = new int[englishWords.Length];
int[] elesScore5 = new int[englishWords.Length];
double[] elesAvScore = new double[englishWords.Length];

int[] nosScore1 = new int[englishWords.Length];
int[] nosScore2 = new int[englishWords.Length];
int[] nosScore3 = new int[englishWords.Length];
int[] nosScore4 = new int[englishWords.Length];
int[] nosScore5 = new int[englishWords.Length];
double[] nosAvScore = new double[englishWords.Length];

int[] vocesScore1 = new int[englishWords.Length];
int[] vocesScore2 = new int[englishWords.Length];
int[] vocesScore3 = new int[englishWords.Length];
int[] vocesScore4 = new int[englishWords.Length];
int[] vocesScore5 = new int[englishWords.Length];
double[] vocesAvScore = new double[englishWords.Length];

string[] formatPT = { "Eu", "Você", "Ele", "Ela", "Eles", "Elas", "Nos", "Vocês" };
string[] formatEN = { "I", "You (singular)", "He", "She", "They", "They (females)", "We", "You (plural)" };
// formatPT[0] = Eu
// formatPT[1] = Você
// formatPT[2] = Ele
// formatPT[3] = Ela
// formatPT[4] = Eles
// formatPT[5] = Elas
// formatPT[6] = Nos
// formatPT[7] = Vocês

Initialize();
PlayGame();

void PlayGame()
{
    bool playingGame = true;
    while (playingGame)
    {
        ScoreCheck();
        Console.Clear();
        Randomize();
        System.Console.WriteLine("");
        System.Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

}

void PlayRound(int Pronoun, int Word)
{
    switch (Pronoun)
    {
        case 0: // Eu
            AnswerCheckPrint(Pronoun, Word, eu, euEn);
            break;
        case 1: // Você
            AnswerCheckPrint(Pronoun, Word, voce, voceEn);
            break;
        case 2: // Ele
            AnswerCheckPrint(Pronoun, Word, ele, eleEn);
            break;
        case 3: // Ela
            AnswerCheckPrint(Pronoun, Word, ele, eleEn);
            break;
        case 4: // Eles
            AnswerCheckPrint(Pronoun, Word, eles, elesEn);
            break;
        case 5: // Elas
            AnswerCheckPrint(Pronoun, Word, eles, elesEn);
            break;
        case 6: // Nos
            AnswerCheckPrint(Pronoun, Word, nos, nosEn);
            break;
        case 7: // Voces
            AnswerCheckPrint(Pronoun, Word, voces, vocesEn);
            break;
    }
}

void AddScore(int pronoun, int point, int word)
{
    switch (pronoun)
    {
        case 0:
            euScore5[word] = euScore4[word];
            euScore4[word] = euScore3[word];
            euScore3[word] = euScore2[word];
            euScore2[word] = euScore1[word];
            euScore1[word] = point;
            break;
        case 1:
            voceScore5[word] = voceScore4[word];
            voceScore4[word] = voceScore3[word];
            voceScore3[word] = voceScore2[word];
            voceScore2[word] = voceScore1[word];
            voceScore1[word] = point;
            break;
        case 2:
            eleScore5[word] = eleScore4[word];
            eleScore4[word] = eleScore3[word];
            eleScore3[word] = eleScore2[word];
            eleScore2[word] = eleScore1[word];
            eleScore1[word] = point;
            break;
        case 3:
            eleScore5[word] = eleScore4[word];
            eleScore4[word] = eleScore3[word];
            eleScore3[word] = eleScore2[word];
            eleScore2[word] = eleScore1[word];
            eleScore1[word] = point;
            break;
        case 4:
            elesScore5[word] = elesScore4[word];
            elesScore4[word] = elesScore3[word];
            elesScore3[word] = elesScore2[word];
            elesScore2[word] = elesScore1[word];
            elesScore1[word] = point;
            break;
        case 5:
            elesScore5[word] = elesScore4[word];
            elesScore4[word] = elesScore3[word];
            elesScore3[word] = elesScore2[word];
            elesScore2[word] = elesScore1[word];
            elesScore1[word] = point;
            break;
        case 6:
            nosScore5[word] = nosScore4[word];
            nosScore4[word] = nosScore3[word];
            nosScore3[word] = nosScore2[word];
            nosScore2[word] = nosScore1[word];
            nosScore1[word] = point;
            break;
        case 7:
            vocesScore5[word] = vocesScore4[word];
            vocesScore4[word] = vocesScore3[word];
            vocesScore3[word] = vocesScore2[word];
            vocesScore2[word] = vocesScore1[word];
            vocesScore1[word] = point;
            break;
    }
}

void ScoreCheck()
{
    for (int i = 0; i < englishWords.Length; i++)
    {
        euAvScore[i] = (euScore1[i] + euScore2[i] + euScore3[i] + euScore4[i] + euScore5[i]) / 5;
        voceAvScore[i] = (voceScore1[i] + voceScore2[i] + voceScore3[i] + voceScore4[i] + voceScore5[i]) / 5;
        eleAvScore[i] = (eleScore1[i] + eleScore2[i] + eleScore3[i] + eleScore4[i] + eleScore5[i]) / 5;
        elesAvScore[i] = (elesScore1[i] + elesScore2[i] + elesScore3[i] + elesScore4[i] + elesScore5[i]) / 5;
        nosAvScore[i] = (nosScore1[i] + nosScore2[i] + nosScore3[i] + nosScore4[i] + nosScore5[i]) / 5;
        vocesAvScore[i] = (vocesScore1[i] + vocesScore2[i] + vocesScore3[i] + vocesScore4[i] + vocesScore5[i]) / 5;
    }
}

void Initialize()
{
    for (int i = 0; i < englishWords.Length; i++)
    {
        euScore1[i] = 0;
        euScore2[i] = 0;
        euScore3[i] = 0;
        euScore4[i] = 0;
        euScore5[i] = 0;
        euAvScore[i] = 0;

        voceScore1[i] = 0;
        voceScore2[i] = 0;
        voceScore3[i] = 0;
        voceScore4[i] = 0;
        voceScore5[i] = 0;
        voceAvScore[i] = 0;

        eleScore1[i] = 0;
        eleScore2[i] = 0;
        eleScore3[i] = 0;
        eleScore4[i] = 0;
        eleScore5[i] = 0;
        eleAvScore[i] = 0;

        elesScore1[i] = 0;
        elesScore2[i] = 0;
        elesScore3[i] = 0;
        elesScore4[i] = 0;
        elesScore5[i] = 0;
        elesAvScore[i] = 0;

        nosScore1[i] = 0;
        nosScore2[i] = 0;
        nosScore3[i] = 0;
        nosScore4[i] = 0;
        nosScore5[i] = 0;
        nosAvScore[i] = 0;

        vocesScore1[i] = 0;
        vocesScore2[i] = 0;
        vocesScore3[i] = 0;
        vocesScore4[i] = 0;
        vocesScore5[i] = 0;
        voceAvScore[i] = 0;
    }
}
void AnswerCheckPrint(int pronoun, int word, string[] wordList, string[] wordListEn)
{
    System.Console.WriteLine($"{formatEN[pronoun]} {wordListEn[word]}");
    System.Console.Write($"{formatPT[pronoun]} ");
    string? answer = Console.ReadLine();
    if (answer == wordList[word])
    {
        Console.Clear();
        System.Console.WriteLine($"You are right!");
        System.Console.WriteLine($"{formatEN[pronoun]} {wordList[word]} is \n{formatPT[pronoun]} {wordList[word]} in portuguese.");
        System.Console.WriteLine("");
        System.Console.WriteLine($"{"Eu",-15} {"Você",-15} {"Ele/Ela",-15} {"Eles/Elas",-15} {"Nos",-15} {"Vocês",-15}");
        System.Console.WriteLine($"{eu[word],-15} {voce[word],-15} {ele[word],-15} {eles[word],-15} {nos[word],-15} {voces[word],-15}");
        AddScore(pronoun, 1, word);
    }
    else
    {
        Console.Clear();
        System.Console.WriteLine("Wrong answer!");
        System.Console.WriteLine($"{formatEN[pronoun]} {wordList[word]} is \n{formatPT[pronoun]} {wordList[word]} in portuguese.");
        System.Console.WriteLine("");
        System.Console.WriteLine($"{"Eu",-15} {"Você",-15} {"Ele/Ela",-15} {"Eles/Elas",-15} {"Nos",-15} {"Vocês",-15}");
        System.Console.WriteLine($"{eu[word],-15} {voce[word],-15} {ele[word],-15} {eles[word],-15} {nos[word],-15} {voces[word],-15}");
        AddScore(pronoun, 0, word);
    }

}

void Randomize()
{
    Console.Clear();
    Random randNr = new Random();
    int whichPronoun = randNr.Next(0, 8);
    int whichWord = randNr.Next(0, 100);
    switch (whichPronoun)
    {
        case 0: // Eu
            if ((euAvScore[whichWord]) < 1)
            {
                PlayRound(whichPronoun, whichWord);
                break;
            }
            else
            {
                break;
            }
        case 1: // Você
            if ((voceAvScore[whichWord]) < 1)
            {
                PlayRound(whichPronoun, whichWord);
                break;
            }
            else
            {
                break;
            }
        case 2: // Ele
            if ((eleAvScore[whichWord]) < 1)
            {
                PlayRound(whichPronoun, whichWord);
                break;
            }
            else
            {
                break;
            }
        case 3: // Ela
            if ((eleAvScore[whichWord]) < 1)
            {
                PlayRound(whichPronoun, whichWord);
                break;
            }
            else
            {
                break;
            }
        case 4: // Eles
            if ((elesAvScore[whichWord]) < 1)
            {
                PlayRound(whichPronoun, whichWord);
                break;
            }
            else
            {
                break;
            }
        case 5: // Elas
            if ((elesAvScore[whichWord]) < 1)
            {
                PlayRound(whichPronoun, whichWord);
                break;
            }
            else
            {
                break;
            }
        case 6: // Nos
            if ((nosAvScore[whichWord]) < 1)
            {
                PlayRound(whichPronoun, whichWord);
                break;
            }
            else
            {
                break;
            }
        case 7: // Vocês
            if ((vocesAvScore[whichWord]) < 1)
            {
                PlayRound(whichPronoun, whichWord);
                break;
            }
            else
            {
                break;
            }

    }


}
