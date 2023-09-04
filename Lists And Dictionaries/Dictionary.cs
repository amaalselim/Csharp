namespace Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var article = "he indefinite article takes two forms. It’s the word a when it precedes a" +
                " word that begins with a consonant. It’s the word an when it precedes a word that begins with a vowel." +
                " The indefinite article indicates that a noun refers to a general idea" +
                " or category of a thing rather than a specific thing. ";
            Dictionary<char,List<string>> letterdic = new Dictionary<char,List<string>>();
            foreach(var word in article.Split())
            {
                foreach(var ch in word)
                {
                    if (!letterdic.ContainsKey(ch))
                    {
                        letterdic.Add(ch,new List<string>());
                    }
                    else
                    {
                        letterdic[ch].Add(word);
                    }
                }
            }
            foreach(var entry in letterdic)
            {
                Console.WriteLine($"'{entry.Key}': ");
                foreach(var word in entry.Value)
                {
                    Console.WriteLine($"\t\t \"{word}\" ");
                }
            }
        }
    }
}