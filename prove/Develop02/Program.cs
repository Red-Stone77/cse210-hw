/* Requirements Exceeded:
Formatted the file so that it looks nice.
Made it so you can save AND delete to .csv files
Organized it so that new entries saved to an existing file
are placed on the top.
*/

using System;
class Program
{
    //temporary storage for user inputs for entries
    static Entry entry = new Entry();
    
    static void Main(string[] args)
    {
        string menu_control = "0";
        do 
        {
            if (menu_control != "0") Console.WriteLine(); //format break after first run

            Console.WriteLine("* ------ * Journal * ------ *");
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("New Journal Entry (1)");
            Console.WriteLine("Display Journal (2)");
            Console.WriteLine("Save Current Journal (3)");
            Console.WriteLine("Load a Journal (4)");
            Console.WriteLine("Wipe a Journal (5)");
            Console.WriteLine("Quit (6)");
            Console.Write("Control: ");
            menu_control = Console.ReadLine();
            Console.WriteLine(); // formatting break


            if (menu_control == "1")
            {
                // Calls from Entry.cs
                entry.GeneratePrompt();
            }
            
            else if (menu_control == "2")
            {
                //calls from Entry.cs
                entry.ShowEntries();
            }

            else if (menu_control == "3")
            {
                //saves entires to a csv file
                Console.Write("What is the name of the file you want to save to?: ");   
                string filename = Console.ReadLine();
                Journal journal = new Journal();
                journal.SaveEntries(filename, entry._savedPrompts);
}

            else if (menu_control == "4")
            {
                //opens a csv file to display
                Console.Write("What is the name of the file you want to load?: "); 
                Journal journal = new Journal();
                string filename = Console.ReadLine();
                journal.ReadSavedEntries(filename);

            }

            else if (menu_control == "5")
            {
                //clears the given file
                Console.Write("What is the name of the file you want to wipe?: ");
                string filename = Console.ReadLine();
                Journal journal = new Journal();
                journal.WipeJournal(filename);
            }

            else if (menu_control == "6")
            {
                Console.WriteLine("Have a good day!");
                break;
            }
        } 
        while (menu_control != "6");

    }
}