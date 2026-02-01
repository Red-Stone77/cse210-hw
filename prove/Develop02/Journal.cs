using System.IO;
using System.Linq.Expressions;

public class Journal
{
    // reads and prints out the contents of the requested csv file
    public void ReadSavedEntries(string filename){
    
    try
    {
    // checks if the requested file is a .csv
    // if not it adds it before requesting the file
        if (!filename.EndsWith(".csv"))
        {
            filename += ".csv";
        }

        string[] lines = System.IO.File.ReadAllLines(filename);
        Console.WriteLine("\n* -------------- * -------------- * -------------- * -------------- * -------------- *\n"); //formatting break

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            string _datePrompt = parts[0];
            string _journalEntry = parts[1];
            Console.WriteLine($"{_datePrompt}\n{_journalEntry}\n");
        }
        Console.WriteLine("* -------------- * -------------- * -------------- * -------------- * -------------- *"); //formatting break
    }

    // stops the code from exploding if a file called doesn't exist
    catch (FileNotFoundException)
    {
        Console.WriteLine($"{filename} does not exist.\n");
    }
    }

    // reads given csv file and saves the current contents
    // then adds the new entries at the top
    public void SaveEntries(string filename, List<string> savedPrompts)
    {   
        // checks if the requested file is a .csv
        // if not it adds it before requesting the file
        if (!filename.EndsWith(".csv"))
        {
            filename += ".csv";
        }
        try {
        {
            List<string> existingLines = new List<string>();

            // checks for existing data in the file
            // and temporarily saves it
            if (File.Exists(filename))
            {
                existingLines = File.ReadAllLines(filename).ToList();
            }

            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                foreach (string p in savedPrompts)
                {   
                    //stores the new entries (prompt + reply) in one line
                    string cleanedEntry = p.Replace("\n", " | ");
                    outputFile.WriteLine(cleanedEntry);
                }
                
                //adds the old data back
                foreach (string line in existingLines)
                {
                    outputFile.WriteLine(line);
                }
            }
            Console.WriteLine($"Saved to {filename}\n");
        }
    }
    // stops the code from exploding if a file called doesn't exist
    catch (FileNotFoundException)
        {
            Console.WriteLine($"{filename} does not exist.\n");
        }
    }

    //allows the user to wipe and delete their journal files
    public void WipeJournal(string filename)
    {

        // checks if the requested file is a .csv
        // if not it adds it before requesting the file
        if (!filename.EndsWith(".csv"))
        {
            filename += ".csv";
        }

        // Deletes the file if it exists
        try
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
                Console.WriteLine($"{filename} has been wiped.\n");
            }
        }
        
        // stops the code from exploding if a file called doesn't exist
        catch (FileNotFoundException)
        {
            Console.WriteLine($"{filename} does not exist.\n");
        }
    }
}