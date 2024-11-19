class GetChange:GetString
{
    public void GetChangeChar()
    {
        string newTXT = text.Trim();
        string[] SplitedText = newTXT.Split(" ");

        foreach (string word in SplitedText)
        {
            if (word.Length > 1)
            {
                ModifiedWord +=word.Substring(1) + word[0] + " ";    
            }
            else
            {
                ModifiedWord +=word + " ";
            }
        }

        Console.WriteLine(ModifiedWord.Trim());
        Console.ReadKey();
    }
}