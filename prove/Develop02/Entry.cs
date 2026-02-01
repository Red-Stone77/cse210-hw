using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class Entry(){
    //list of possible entry prompts
    public List<String> _prompt = new List<String>{
    "Who was the most interesting person I interacted with today?",
    "What was the best part of my day?",
    "How did I see the hand of the Lord in my life today?",
    "What was the strongest emotion I felt today?",
    "If I had one thing I could do over today, what would it be?",
    "What is one thing about your body you are grateful for today?",
    "What is a feeling you’re currently trying to avoid?",
    "What do you need to hear most right now?",
    "What is a risk you’re considering taking?",
    "What is one thing you can do today to help your future self?",
    "What is your 'theme song' for this week?"};

    public List<String> _savedPrompts = new List<string>();

    //randomly selects a prompt and then stores the date, prompt, and response in a list
    public void GeneratePrompt()
    {   

        //code for random entry
        Random _rnd = new Random();
        int randomNumber = _rnd.Next(0,_prompt.Count);
        string _tempPrompt = _prompt[randomNumber];
        Console.WriteLine(_tempPrompt);
        Console.Write("> ");
        string response = Console.ReadLine();

        //grabs current date as a string
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        //saves to a list
        string _savePrompt = $"Date: {dateText} - Prompt: {_tempPrompt}\n> {response}";
        _savedPrompts.Insert(0,_savePrompt);
        Console.WriteLine(); //formatting break
    }

    
    public void ShowEntries()
    {
        //code to display the current unsaved Journal
        //prints from the list
        foreach (string p in _savedPrompts)
        {
            Console.WriteLine($"{p}\n");
        }
    }
}