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

int[] voceScore1 = new int[englishWords.Length];
int[] voceScore2 = new int[englishWords.Length];
int[] voceScore3 = new int[englishWords.Length];
int[] voceScore4 = new int[englishWords.Length];
int[] voceScore5 = new int[englishWords.Length];

int[] eleScore1 = new int[englishWords.Length];
int[] eleScore2 = new int[englishWords.Length];
int[] eleScore3 = new int[englishWords.Length];
int[] eleScore4 = new int[englishWords.Length];
int[] eleScore5 = new int[englishWords.Length];

int[] elesScore1 = new int[englishWords.Length];
int[] elesScore2 = new int[englishWords.Length];
int[] elesScore3 = new int[englishWords.Length];
int[] elesScore4 = new int[englishWords.Length];
int[] elesScore5 = new int[englishWords.Length];

int[] nosScore1 = new int[englishWords.Length];
int[] nosScore2 = new int[englishWords.Length];
int[] nosScore3 = new int[englishWords.Length];
int[] nosScore4 = new int[englishWords.Length];
int[] nosScore5 = new int[englishWords.Length];

int[] vocesScore1 = new int[englishWords.Length];
int[] vocesScore2 = new int[englishWords.Length];
int[] vocesScore3 = new int[englishWords.Length];
int[] vocesScore4 = new int[englishWords.Length];
int[] vocesScore5 = new int[englishWords.Length];

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
        Console.Clear();
        Random randNr = new Random();
        int whichPronoun = randNr.Next(0, 8);
        int whichWord = randNr.Next(0, 100);
        PlayRound(whichPronoun, whichWord);
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
            System.Console.WriteLine($"{formatEN[0]} {euEn[Word]}");
            System.Console.Write($"{formatPT[0]} ");
            string? answer0 = Console.ReadLine();
            if (answer0 == eu[Word])
            { 
                Console.Clear();
                System.Console.WriteLine($"You are right!");
                System.Console.WriteLine($"{formatEN[0]} {euEn[Word]} is \n{formatPT[0]} {eu[Word]} in portuguese.");
                System.Console.WriteLine("");
                System.Console.WriteLine($"{"Eu", -15} {"Você", -15} {"Ele/Ela", -15} {"Eles/Elas", -15} {"Nos", -15} {"Vocês", -15}"); 
                System.Console.WriteLine($"{eu[Word], -15} {voce[Word], -15} {ele[Word], -15} {eles[Word], -15} {nos[Word], -15} {voces[Word], -15}"); 
                AddScore(Pronoun, 1, Word);
            }
            else
            {
                System.Console.WriteLine("Wrong answer!");
                System.Console.WriteLine($"{formatEN[0]} {euEn[Word]} is \n{formatPT[0]} {eu[Word]} in portuguese.");
                System.Console.WriteLine("");
                System.Console.WriteLine($"{"Eu", -15} {"Você", -15} {"Ele/Ela", -15} {"Eles/Elas", -15} {"Nos", -15} {"Vocês", -15}"); 
                System.Console.WriteLine($"{eu[Word], -15} {voce[Word], -15} {ele[Word], -15} {eles[Word], -15} {nos[Word], -15} {voces[Word], -15}"); 
                AddScore(Pronoun, 0, Word);
            }
            break;
        case 1: // Você
            System.Console.WriteLine($"{formatEN[1]} {voceEn[Word]}");
            System.Console.Write($"{formatPT[1]} ");
            string? answer1 = Console.ReadLine();
            if (answer1 == voce[Word])
            {
                System.Console.WriteLine($"You are right!");
                System.Console.WriteLine($"{formatEN[1]} {voceEn[Word]} is \n{formatPT[1]} {voce[Word]} in portuguese.");
                System.Console.WriteLine("");
                System.Console.WriteLine($"{"Eu", -15} {"Você", -15} {"Ele/Ela", -15} {"Eles/Elas", -15} {"Nos", -15} {"Vocês", -15}"); 
                System.Console.WriteLine($"{eu[Word], -15} {voce[Word], -15} {ele[Word], -15} {eles[Word], -15} {nos[Word], -15} {voces[Word], -15}"); 
                AddScore(Pronoun, 1, Word);
            }
            else
            {
                System.Console.WriteLine("Wrong answer!");
                System.Console.WriteLine($"{formatEN[1]} {voceEn[Word]} is \n{formatPT[1]} {voce[Word]} in portuguese.");
                System.Console.WriteLine("");
                System.Console.WriteLine($"{"Eu", -15} {"Você", -15} {"Ele/Ela", -15} {"Eles/Elas", -15} {"Nos", -15} {"Vocês", -15}"); 
                System.Console.WriteLine($"{eu[Word], -15} {voce[Word], -15} {ele[Word], -15} {eles[Word], -15} {nos[Word], -15} {voces[Word], -15}"); 
                AddScore(Pronoun, 0, Word);
            }
            break;
        case 2: // Ele
            System.Console.WriteLine($"{formatEN[2]} {eleEn[Word]}");
            System.Console.Write($"{formatPT[2]} ");
            string? answer2 = Console.ReadLine();
            if (answer2 == ele[Word])
            {
                System.Console.WriteLine($"You are right!");
                System.Console.WriteLine($"{formatEN[2]} {eleEn[Word]} is \n{formatPT[2]} {ele[Word]} in portuguese.");
                System.Console.WriteLine("");
                System.Console.WriteLine($"{"Eu", -15} {"Você", -15} {"Ele/Ela", -15} {"Eles/Elas", -15} {"Nos", -15} {"Vocês", -15}"); 
                System.Console.WriteLine($"{eu[Word], -15} {voce[Word], -15} {ele[Word], -15} {eles[Word], -15} {nos[Word], -15} {voces[Word], -15}"); 
                AddScore(Pronoun, 1, Word);
            }
            else
            {
                System.Console.WriteLine("Wrong answer!");
                System.Console.WriteLine($"{formatEN[2]} {eleEn[Word]} is \n{formatPT[2]} {ele[Word]} in portuguese.");
                System.Console.WriteLine("");
                System.Console.WriteLine($"{"Eu", -15} {"Você", -15} {"Ele/Ela", -15} {"Eles/Elas", -15} {"Nos", -15} {"Vocês", -15}"); 
                System.Console.WriteLine($"{eu[Word], -15} {voce[Word], -15} {ele[Word], -15} {eles[Word], -15} {nos[Word], -15} {voces[Word], -15}"); 
                AddScore(Pronoun, 0, Word);
            }
            break;
        case 3: // Ela
            System.Console.WriteLine($"{formatEN[3]} {eleEn[Word]}");
            System.Console.Write($"{formatPT[3]} ");
            string? answer3 = Console.ReadLine();
            if (answer3 == ele[Word])
            {
                System.Console.WriteLine($"You are right!");
                System.Console.WriteLine($"{formatEN[3]} {eleEn[Word]} is \n{formatPT[3]} {ele[Word]} in portuguese.");
                System.Console.WriteLine("");
                System.Console.WriteLine($"{"Eu", -15} {"Você", -15} {"Ele/Ela", -15} {"Eles/Elas", -15} {"Nos", -15} {"Vocês", -15}"); 
                System.Console.WriteLine($"{eu[Word], -15} {voce[Word], -15} {ele[Word], -15} {eles[Word], -15} {nos[Word], -15} {voces[Word], -15}"); 
                AddScore(Pronoun, 1, Word);
            }
            else
            {
                System.Console.WriteLine("Wrong answer!");
                System.Console.WriteLine($"{formatEN[3]} {eleEn[Word]} is \n{formatPT[3]} {ele[Word]} in portuguese.");
                System.Console.WriteLine("");
                System.Console.WriteLine($"{"Eu", -15} {"Você", -15} {"Ele/Ela", -15} {"Eles/Elas", -15} {"Nos", -15} {"Vocês", -15}"); 
                System.Console.WriteLine($"{eu[Word], -15} {voce[Word], -15} {ele[Word], -15} {eles[Word], -15} {nos[Word], -15} {voces[Word], -15}"); 
                AddScore(Pronoun, 0, Word);
            }
            break;
        case 4: // Eles
            System.Console.WriteLine($"{formatEN[4]} {elesEn[Word]}");
            System.Console.Write($"{formatPT[4]} ");
            string? answer4 = Console.ReadLine();
            if (answer4 == eles[Word])
            {
                System.Console.WriteLine($"You are right!");
                System.Console.WriteLine($"{formatEN[4]} {elesEn[Word]} is \n{formatPT[4]} {eles[Word]} in portuguese.");
                System.Console.WriteLine("");
                System.Console.WriteLine($"{"Eu", -15} {"Você", -15} {"Ele/Ela", -15} {"Eles/Elas", -15} {"Nos", -15} {"Vocês", -15}"); 
                System.Console.WriteLine($"{eu[Word], -15} {voce[Word], -15} {ele[Word], -15} {eles[Word], -15} {nos[Word], -15} {voces[Word], -15}"); 
                AddScore(Pronoun, 1, Word);
            }
            else
            {
                System.Console.WriteLine("Wrong answer!");
                System.Console.WriteLine($"{formatEN[4]} {elesEn[Word]} is \n{formatPT[4]} {eles[Word]} in portuguese.");
                System.Console.WriteLine("");
                System.Console.WriteLine($"{"Eu", -15} {"Você", -15} {"Ele/Ela", -15} {"Eles/Elas", -15} {"Nos", -15} {"Vocês", -15}"); 
                System.Console.WriteLine($"{eu[Word], -15} {voce[Word], -15} {ele[Word], -15} {eles[Word], -15} {nos[Word], -15} {voces[Word], -15}"); 
                AddScore(Pronoun, 0, Word);
            }
            break;
        case 5: // Elas
            System.Console.WriteLine($"{formatEN[5]} {elesEn[Word]}");
            System.Console.Write($"{formatPT[5]} ");
            string? answer5 = Console.ReadLine();
            if (answer5 == eles[Word])
            {
                System.Console.WriteLine($"You are right!");
                System.Console.WriteLine($"{formatEN[5]} {elesEn[Word]} is \n{formatPT[5]} {eles[Word]} in portuguese.");
                System.Console.WriteLine("");
                System.Console.WriteLine($"{"Eu", -15} {"Você", -15} {"Ele/Ela", -15} {"Eles/Elas", -15} {"Nos", -15} {"Vocês", -15}"); 
                System.Console.WriteLine($"{eu[Word], -15} {voce[Word], -15} {ele[Word], -15} {eles[Word], -15} {nos[Word], -15} {voces[Word], -15}"); 
                AddScore(Pronoun, 1, Word);
            }
            else
            {
                System.Console.WriteLine("Wrong answer!");
                System.Console.WriteLine($"{formatEN[5]} {elesEn[Word]} is \n{formatPT[5]} {eles[Word]} in portuguese.");
                System.Console.WriteLine("");
                System.Console.WriteLine($"{"Eu", -15} {"Você", -15} {"Ele/Ela", -15} {"Eles/Elas", -15} {"Nos", -15} {"Vocês", -15}"); 
                System.Console.WriteLine($"{eu[Word], -15} {voce[Word], -15} {ele[Word], -15} {eles[Word], -15} {nos[Word], -15} {voces[Word], -15}"); 
                AddScore(Pronoun, 0, Word);
            }
            break;
        case 6: // Nos
            System.Console.WriteLine($"{formatEN[6]} {nosEn[Word]}");
            System.Console.Write($"{formatPT[6]} ");
            string? answer6 = Console.ReadLine();
            if (answer6 == nos[Word])
            {
                System.Console.WriteLine($"You are right!");
                System.Console.WriteLine($"{formatEN[6]} {nosEn[Word]} is \n{formatPT[6]} {nos[Word]} in portuguese.");
                System.Console.WriteLine("");
                System.Console.WriteLine($"{"Eu", -15} {"Você", -15} {"Ele/Ela", -15} {"Eles/Elas", -15} {"Nos", -15} {"Vocês", -15}"); 
                System.Console.WriteLine($"{eu[Word], -15} {voce[Word], -15} {ele[Word], -15} {eles[Word], -15} {nos[Word], -15} {voces[Word], -15}"); 
                AddScore(Pronoun, 1, Word);
            }
            else
            {
                System.Console.WriteLine("Wrong answer!");
                System.Console.WriteLine($"{formatEN[6]} {nosEn[Word]} is \n{formatPT[6]} {nos[Word]} in portuguese.");
                System.Console.WriteLine("");
                System.Console.WriteLine($"{"Eu", -15} {"Você", -15} {"Ele/Ela", -15} {"Eles/Elas", -15} {"Nos", -15} {"Vocês", -15}"); 
                System.Console.WriteLine($"{eu[Word], -15} {voce[Word], -15} {ele[Word], -15} {eles[Word], -15} {nos[Word], -15} {voces[Word], -15}"); 
                AddScore(Pronoun, 0, Word);
            }
            break;
        case 7: // Voces
            System.Console.WriteLine($"{formatEN[7]} {vocesEn[Word]}");
            System.Console.Write($"{formatPT[7]} ");
            string? answer7 = Console.ReadLine();
            if (answer7 == voces[Word])
            {
                System.Console.WriteLine($"You are right!");
                System.Console.WriteLine($"{formatEN[7]} {vocesEn[Word]} is \n{formatPT[7]} {voces[Word]} in portuguese.");
                System.Console.WriteLine("");
                System.Console.WriteLine($"{"Eu", -15} {"Você", -15} {"Ele/Ela", -15} {"Eles/Elas", -15} {"Nos", -15} {"Vocês", -15}"); 
                System.Console.WriteLine($"{eu[Word], -15} {voce[Word], -15} {ele[Word], -15} {eles[Word], -15} {nos[Word], -15} {voces[Word], -15}"); 
                AddScore(Pronoun, 1, Word);
            }
            else
            {
                System.Console.WriteLine("Wrong answer!");
                System.Console.WriteLine($"{formatEN[7]} {vocesEn[Word]} is \n{formatPT[7]} {voces[Word]} in portuguese.");
                System.Console.WriteLine("");
                System.Console.WriteLine($"{"Eu", -15} {"Você", -15} {"Ele/Ela", -15} {"Eles/Elas", -15} {"Nos", -15} {"Vocês", -15}"); 
                System.Console.WriteLine($"{eu[Word], -15} {voce[Word], -15} {ele[Word], -15} {eles[Word], -15} {nos[Word], -15} {voces[Word], -15}"); 
                AddScore(Pronoun, 0, Word);
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

        voceScore1[i] = 0;
        voceScore2[i] = 0;
        voceScore3[i] = 0;
        voceScore4[i] = 0;
        voceScore5[i] = 0;

        eleScore1[i] = 0;
        eleScore2[i] = 0;
        eleScore3[i] = 0;
        eleScore4[i] = 0;
        eleScore5[i] = 0;

        elesScore1[i] = 0;
        elesScore2[i] = 0;
        elesScore3[i] = 0;
        elesScore4[i] = 0;
        elesScore5[i] = 0;

        nosScore1[i] = 0;
        nosScore2[i] = 0;
        nosScore3[i] = 0;
        nosScore4[i] = 0;
        nosScore5[i] = 0;

        vocesScore1[i] = 0;
        vocesScore2[i] = 0;
        vocesScore3[i] = 0;
        vocesScore4[i] = 0;
        vocesScore5[i] = 0;
    }
}