/*
Depending on the option: write a console application that moves the first letter 
of the word to the end or replaces the letters in the word
*/

GetChange obj1 = new GetChange();
CharSwapper obj2 = new CharSwapper();

Console.Clear();
Console.WriteLine("Move the first letter of each word to the end(1)");
Console.WriteLine("Replace adjacent characters in words(2)");
again:Console.Write("\nChoose an option: ");
string reply = Console.ReadLine();
switch (reply)
{
    case "1":
    obj1.GetTheString();
    obj1.GetChangeChar();
    break;

    case "2":
    obj2.GetTheString();
    obj2.SwapCharacters();
    break;

    default:
    Console.WriteLine("Invalid option!");
    goto again;
}