while (true)
{
    Console.Write("Input the string: ");
    string sentence1 = Console.ReadLine().ToLower();

    Console.Write("Input the substring to search: ");
    string sentence2 = Console.ReadLine().ToLower();

    string[] words1 = sentence1.Split(' ');
    string[] words2 = sentence2.Split(' ');

    bool found = false;
    foreach (string word in words2)
    {
        if (Array.Exists(words1, w => w == word))
        {
            found = true;
            break;
        }
    }

    if (found)
        Console.WriteLine("The substring exists in the string.");
    else
        Console.WriteLine("The substring does not exist in the string.");

    // Ask to continue
    while (true)
    {
        Console.Write("Do you want to continue? Y or N: ");
        string answer = Console.ReadLine().ToLower();

        if (answer == "y") break;
        else if (answer == "n")
        {
            Console.WriteLine("Close program");
            return;
        }
        else
            Console.WriteLine("There is an error, choose Y or N");
    }
}