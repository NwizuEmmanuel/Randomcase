internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter a word: ");
        string? word = Console.ReadLine();

        int wordLength = word!.Length;

        string lastLetter = Convert.ToString(word[wordLength - 1]).ToUpper();
        string firstLetter = Convert.ToString(word[0]).ToUpper();
        string secondToLastLetter = Convert.ToString(word[wordLength - 2]).ToUpper();

        word = word.Replace(word[0], Convert.ToChar(firstLetter));
        word = word.Replace(word[wordLength - 1], Convert.ToChar(lastLetter));
        word = word.Replace(word[wordLength - 2], Convert.ToChar(secondToLastLetter));

        Console.WriteLine(word);
    }
}