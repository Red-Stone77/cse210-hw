using System;

class Program
{
    static void Main(string[] args)
    {

        Boolean game = true;

        do {
        //Console.Write("What is the magic number? ");
        //int magicnumber = Convert.ToInt32(Console.ReadLine());
        Random randomGenerator = new Random();
        int magicnumber = randomGenerator.Next(1, 100);
        
        int guess;
        int guessnumber = 0;


        do{
        Console.Write("What is your guess? ");
        guess = Convert.ToInt32(Console.ReadLine());
        guessnumber++;

        if (magicnumber > guess){Console.WriteLine("Higher.");}
        else if (magicnumber < guess){Console.WriteLine("Lower.");}
        } while (guess != magicnumber);

        Console.WriteLine($"Congrats! You correctly guessed the number in {guessnumber} guesses! The number was {guess}!");
        Console.Write("Would you like to play again? ");
        string play = Console.ReadLine();
        if (play.Contains("N".ToLower())){game = false;}
        else {guess = 0; guessnumber = 0;Console.Clear();}
        } while (game);    
    
    
    }
}