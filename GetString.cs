class GetString
{
    public string text{get; set;}
    public string ModifiedWord{get; set;} = "";
    public void GetTheString()
    {
        Console.Clear();
        Console.WriteLine("please enter text to reverse");
        text = Console.ReadLine();
    }
}