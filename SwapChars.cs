class CharSwapper:GetString
{
    public void SwapCharacters()
    {
        string newTXT = text.Trim();
        string[] SplitedText = newTXT.Split(" ");

        foreach (string word in SplitedText)
        {
            char[] charArray = word.ToCharArray();

            for (int i = 1; i < charArray.Length; i += 2)
            {
                char temp = charArray[i-1];
                charArray[i-1] = charArray[i];
                charArray[i] = temp;
            }

            ModifiedWord += new string(charArray) +  " "; 
        }

        Console.WriteLine(ModifiedWord.Trim());
        Console.ReadKey();
    }
}