using System;
class isstartequalword
{
    static void Main()
    {
        Console.WriteLine("Input the word for checking in the start.");
        string word = Console.ReadLine();
        Console.WriteLine("Now, input the text for checking.");
        string text = Console.ReadLine();
        Console.WriteLine(text.StartsWith(word));
        Console.ReadKey(true);
    }
}
