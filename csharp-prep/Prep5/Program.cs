using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string username = PromptUserName();
        int userNumber = PromptUserNumber();
        int birthyear;
        PromptUserBirthYear(out birthyear);
        int squareNumber = SquareNumber(userNumber);

        DisplayResult(username, squareNumber, birthyear);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string s = Console.ReadLine();
        return s;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int x = int.Parse(Console.ReadLine());
        return x;
    }

    static int PromptUserBirthYear(out int y)
    {
        Console.Write("Please enter the year you were born: ");
        y = int.Parse(Console.ReadLine());
        return y;
    }

    static int SquareNumber(int s)
    {
        return s*s;
    }

    static void DisplayResult(string name, int square, int birthyear)
    {
        Console.WriteLine($"{name}, the square of your number is {square}.");
        Console.WriteLine($"{name}, you will turn {2025 - birthyear} years old this year.");
    }
}