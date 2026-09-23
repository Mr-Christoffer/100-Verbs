using System.Globalization;
using System.Text.Json;

const string FilePath = "scores.json";

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
double[] euTotalScore = new double[englishWords.Length];

int[] voceScore1 = new int[englishWords.Length];
int[] voceScore2 = new int[englishWords.Length];
int[] voceScore3 = new int[englishWords.Length];
int[] voceScore4 = new int[englishWords.Length];
int[] voceScore5 = new int[englishWords.Length];
double[] voceTotalScore = new double[englishWords.Length];

int[] eleScore1 = new int[englishWords.Length];
int[] eleScore2 = new int[englishWords.Length];
int[] eleScore3 = new int[englishWords.Length];
int[] eleScore4 = new int[englishWords.Length];
int[] eleScore5 = new int[englishWords.Length];
double[] eleTotalScore = new double[englishWords.Length];

int[] elesScore1 = new int[englishWords.Length];
int[] elesScore2 = new int[englishWords.Length];
int[] elesScore3 = new int[englishWords.Length];
int[] elesScore4 = new int[englishWords.Length];
int[] elesScore5 = new int[englishWords.Length];
double[] elesTotalScore = new double[englishWords.Length];

int[] nosScore1 = new int[englishWords.Length];
int[] nosScore2 = new int[englishWords.Length];
int[] nosScore3 = new int[englishWords.Length];
int[] nosScore4 = new int[englishWords.Length];
int[] nosScore5 = new int[englishWords.Length];
double[] nosTotalScore = new double[englishWords.Length];

int[] vocesScore1 = new int[englishWords.Length];
int[] vocesScore2 = new int[englishWords.Length];
int[] vocesScore3 = new int[englishWords.Length];
int[] vocesScore4 = new int[englishWords.Length];
int[] vocesScore5 = new int[englishWords.Length];
double[] vocesTotalScore = new double[englishWords.Length];

int[][] AllScores() => new int[][]
{
    euScore1, euScore2, euScore3, euScore4, euScore5,
    voceScore1, voceScore2, voceScore3, voceScore4, voceScore5,
    eleScore1, eleScore2, eleScore3, eleScore4, eleScore5,
    elesScore1, elesScore2, elesScore3, elesScore4, elesScore5,
    nosScore1, nosScore2, nosScore3, nosScore4, nosScore5,
    vocesScore1, vocesScore2, vocesScore3, vocesScore4, vocesScore5
};

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
LoadScores();
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
            ScoreCheck();
            System.Console.WriteLine("");
            System.Console.WriteLine($"Points: {euTotalScore[Word]} / 5");
            if (euTotalScore[Word] == 5)
            {
                System.Console.WriteLine("");
                System.Console.WriteLine("CONGRATULATIONS. YOU HAVE 5 CORRECT ANSWERS. YOU WILL NOT SEE THIS WORD AGAIN!!");
                System.Console.WriteLine("");
            }
            break;
        case 1: // Você
            AnswerCheckPrint(Pronoun, Word, voce, voceEn);
            ScoreCheck();
            System.Console.WriteLine("");
            System.Console.WriteLine($"Points: {voceTotalScore[Word]} / 5");
            if (voceTotalScore[Word] == 5)
            {
                System.Console.WriteLine("");
                System.Console.WriteLine("CONGRATULATIONS. YOU HAVE 5 CORRECT ANSWERS. YOU WILL NOT SEE THIS WORD AGAIN!!");
                System.Console.WriteLine("");
            }
            break;
        case 2: // Ele
            AnswerCheckPrint(Pronoun, Word, ele, eleEn);
            ScoreCheck();
            System.Console.WriteLine("");
            System.Console.WriteLine($"Points: {eleTotalScore[Word]} / 5");
            if (eleTotalScore[Word] == 5)
            {
                System.Console.WriteLine("");
                System.Console.WriteLine("CONGRATULATIONS. YOU HAVE 5 CORRECT ANSWERS. YOU WILL NOT SEE THIS WORD AGAIN!!");
                System.Console.WriteLine("");
            }
            break;
        case 3: // Ela
            AnswerCheckPrint(Pronoun, Word, ele, eleEn);
            ScoreCheck();
            System.Console.WriteLine("");
            System.Console.WriteLine($"Points: {eleTotalScore[Word]} / 5");
            if (eleTotalScore[Word] == 5)
            {
                System.Console.WriteLine("");
                System.Console.WriteLine("CONGRATULATIONS. YOU HAVE 5 CORRECT ANSWERS. YOU WILL NOT SEE THIS WORD AGAIN!!");
                System.Console.WriteLine("");
            }
            break;
        case 4: // Eles
            AnswerCheckPrint(Pronoun, Word, eles, elesEn);
            ScoreCheck();
            System.Console.WriteLine("");
            System.Console.WriteLine($"Points: {elesTotalScore[Word]} / 5");
            if (elesTotalScore[Word] == 5)
            {
                System.Console.WriteLine("");
                System.Console.WriteLine("CONGRATULATIONS. YOU HAVE 5 CORRECT ANSWERS. YOU WILL NOT SEE THIS WORD AGAIN!!");
                System.Console.WriteLine("");
            }
            break;
        case 5: // Elas
            AnswerCheckPrint(Pronoun, Word, eles, elesEn);
            ScoreCheck();
            System.Console.WriteLine("");
            System.Console.WriteLine($"Points: {elesTotalScore[Word]} / 5");
            if (elesTotalScore[Word] == 5)
            {
                System.Console.WriteLine("");
                System.Console.WriteLine("CONGRATULATIONS. YOU HAVE 5 CORRECT ANSWERS. YOU WILL NOT SEE THIS WORD AGAIN!!");
                System.Console.WriteLine("");
            }
            break;
        case 6: // Nos
            AnswerCheckPrint(Pronoun, Word, nos, nosEn);
            ScoreCheck();
            System.Console.WriteLine("");
            System.Console.WriteLine($"Points: {nosTotalScore[Word]} / 5");
            if (nosTotalScore[Word] == 5)
            {
                System.Console.WriteLine("");
                System.Console.WriteLine("CONGRATULATIONS. YOU HAVE 5 CORRECT ANSWERS. YOU WILL NOT SEE THIS WORD AGAIN!!");
                System.Console.WriteLine("");
            }
            break;
        case 7: // Voces
            AnswerCheckPrint(Pronoun, Word, voces, vocesEn);
            ScoreCheck();
            System.Console.WriteLine("");
            System.Console.WriteLine($"Points: {vocesTotalScore[Word]} / 5");
            if (vocesTotalScore[Word] == 5)
            {
                System.Console.WriteLine("");
                System.Console.WriteLine("CONGRATULATIONS. YOU HAVE 5 CORRECT ANSWERS. YOU WILL NOT SEE THIS WORD AGAIN!!");
                System.Console.WriteLine("");
            }
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
    SaveScores();
}

void ScoreCheck()
{
    for (int i = 0; i < englishWords.Length; i++)
    {
        euTotalScore[i] = (euScore1[i] + euScore2[i] + euScore3[i] + euScore4[i] + euScore5[i]);
        voceTotalScore[i] = (voceScore1[i] + voceScore2[i] + voceScore3[i] + voceScore4[i] + voceScore5[i]);
        eleTotalScore[i] = (eleScore1[i] + eleScore2[i] + eleScore3[i] + eleScore4[i] + eleScore5[i]);
        elesTotalScore[i] = (elesScore1[i] + elesScore2[i] + elesScore3[i] + elesScore4[i] + elesScore5[i]);
        nosTotalScore[i] = (nosScore1[i] + nosScore2[i] + nosScore3[i] + nosScore4[i] + nosScore5[i]);
        vocesTotalScore[i] = (vocesScore1[i] + vocesScore2[i] + vocesScore3[i] + vocesScore4[i] + vocesScore5[i]);
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
        System.Console.WriteLine($"{formatEN[pronoun]} {wordListEn[word]} is \n{formatPT[pronoun]} {wordList[word]} in portuguese.");
        System.Console.WriteLine("");
        System.Console.WriteLine($"Verb: {portugueseWords[word]}");
        System.Console.WriteLine("");
        System.Console.WriteLine($"{"Eu",-15} {"Você",-15} {"Ele/Ela",-15} {"Eles/Elas",-15} {"Nos",-15} {"Vocês",-15}");
        System.Console.WriteLine($"{eu[word],-15} {voce[word],-15} {ele[word],-15} {eles[word],-15} {nos[word],-15} {voces[word],-15}");
        AddScore(pronoun, 1, word);
    }
    else
    {
        Console.Clear();
        System.Console.WriteLine("Wrong answer!");
        System.Console.WriteLine($"{formatEN[pronoun]} {wordListEn[word]} is \n{formatPT[pronoun]} {wordList[word]} in portuguese.");
        System.Console.WriteLine("");
        System.Console.WriteLine($"Verb: {portugueseWords[word]}");
        System.Console.WriteLine("");
        System.Console.WriteLine($"{"Eu",-15} {"Você",-15} {"Ele/Ela",-15} {"Eles/Elas",-15} {"Nos",-15} {"Vocês",-15}");
        System.Console.WriteLine($"{eu[word],-15} {voce[word],-15} {ele[word],-15} {eles[word],-15} {nos[word],-15} {voces[word],-15}");
        AddScore(pronoun, 0, word);
    }

}

void Randomize()
{
    Console.Clear();
    bool randomize = true;
    while (randomize)
    {
        Random randNr = new Random();
        int whichPronoun = randNr.Next(0, 8);
        int whichWord = randNr.Next(0, 100);
        switch (whichPronoun)
        {
            case 0: // Eu
                if ((euTotalScore[whichWord]) < 5)
                {
                    PlayRound(whichPronoun, whichWord);
                    randomize = false;
                    break;
                }
                else
                {
                    break;
                }
            case 1: // Você
                if ((voceTotalScore[whichWord]) < 5)
                {
                    PlayRound(whichPronoun, whichWord);
                    randomize = false;
                    break;
                }
                else
                {
                    break;
                }
            case 2: // Ele
                if ((eleTotalScore[whichWord]) < 5)
                {
                    PlayRound(whichPronoun, whichWord);
                    randomize = false;
                    break;
                }
                else
                {
                    break;
                }
            case 3: // Ela
                if ((eleTotalScore[whichWord]) < 5)
                {
                    PlayRound(whichPronoun, whichWord);
                    randomize = false;
                    break;
                }
                else
                {
                    break;
                }
            case 4: // Eles
                if ((elesTotalScore[whichWord]) < 5)
                {
                    PlayRound(whichPronoun, whichWord);
                    randomize = false;
                    break;
                }
                else
                {
                    break;
                }
            case 5: // Elas
                if ((elesTotalScore[whichWord]) < 5)
                {
                    PlayRound(whichPronoun, whichWord);
                    randomize = false;
                    break;
                }
                else
                {
                    break;
                }
            case 6: // Nos
                if ((nosTotalScore[whichWord]) < 5)
                {
                    PlayRound(whichPronoun, whichWord);
                    randomize = false;
                    break;
                }
                else
                {
                    break;
                }
            case 7: // Vocês
                if ((vocesTotalScore[whichWord]) < 5)
                {
                    PlayRound(whichPronoun, whichWord);
                    randomize = false;
                    break;
                }
                else
                {
                    break;
                }
        }
    }


}

void SaveScores()
{
    string json = JsonSerializer.Serialize(AllScores());
    File.WriteAllText(FilePath, json);
}

void LoadScores()
{
    if (!File.Exists(FilePath))
        return;   // Ingen sparfil än, behåll arrayerna som de är

    string json = File.ReadAllText(FilePath);
    int[][]? loaded = JsonSerializer.Deserialize<int[][]>(json);
    if (loaded == null)
        return;

    int[][] targets = AllScores();
    for (int i = 0; i < targets.Length && i < loaded.Length; i++)
    {
        int count = Math.Min(loaded[i].Length, targets[i].Length);
        Array.Copy(loaded[i], targets[i], count);
    }
}