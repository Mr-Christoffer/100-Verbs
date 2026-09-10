string[] englishWords = File.ReadAllLines("english.txt");
string[] portugueseWords = File.ReadAllLines("portuguese.txt");

System.Console.WriteLine(portugueseWords[80] + "\t" + englishWords[80]);