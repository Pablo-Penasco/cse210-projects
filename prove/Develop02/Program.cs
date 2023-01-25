using System;


//Create a new Class called Prompt Generator to generate prompts for the user and display them.
public class PromptGenerator
{
    //Constructor for the new class
    public PromptGenerator()
    {
    }

    //Method #1 Generates a random number
    public void RandomNumber()
    {
        Random rnd = new Random();
        int randomInt = rnd.Next(1,6);
    }

    //Method #2 Displays a prompt to the user from a list of prompts. Always chooses a fresh prompt.
    public void DisplayPrompt()
    {
        //list of prompts to choose from
        //1. Write about something you did before work:
        //2. Write about something interesting at work:
        //3. Write about something that happened when you got home:
        //4. What is your vision for tomorrow?
        //5. What did you do well today?
        //6. What was challenging today?

        //how will the DisplayPrompt method choose between the different prompts? pull randomInt from RandomNumber method and use a While loop + If statements to cycle through the prompts.

        if  = 

    }



}

//Create a new class called Entry with 3 attributes: date, prompt that was answered by the user, user entry.
public class Entry
{
    //Constructor for the new class
    public Entry()
    {
    }

    //Attribute #1 date
    public string _Date = "";

    //Attribute #2 Prompt that was answered
    public string _AnsweredPrompt = "";

    //Attribute #3 User answer to the prompt
    public string _journalEntry = "";
}

//Create class called "Journal" with 3 methods: journal entries list, save file, load file. 1 Attribute: list of entries either pulled from file OR Entry(class) instance.
public class Journal
{
    //Constructor for the new class
    public Journal()
    {
    }

    //Attribute #1 
    public string _journalList = "";

    //Method #1 used to save the journal entry to a file
    public void SaveFile()
    {

    }

    //Method #2 used to load the entry in the file and make it available as a string to be displayed
    public void LoadFile()
    {

    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
    }
}