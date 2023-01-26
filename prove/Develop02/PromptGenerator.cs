//Create a new Class called Prompt Generator to generate prompts for the user and display them.
public class PromptGenerator
{
    //list of prompts to choose from
    public string _prompt1 = "1. Write about something you did before work:";
    public string _prompt2 = "2. Write about something interesting at work:";
    public string _prompt3 = "3. Write about something that happened when you got home:";
    public string _prompt4 = "4. What is your vision for tomorrow?";
    public string _prompt5 = "5. What did you do well today?";
    public string _prompt6 = "6. What was challenging today?";

    //public int _randomInt;


    //Constructor for the new class
    public PromptGenerator()
    {
    }

    //Method #1 Displays a prompt to the user from a list of prompts. Always chooses a fresh prompt using a pseudo random number 1-6.
    public void DisplayPrompt()
    {
        Random rnd = new Random();
        int randomInt = rnd.Next(1,6);
        
        //How will the DisplayPrompt method choose between the different prompts? Create a random Interger and use a While loop + If statements to cycle through the prompts.
        while (randomInt != 0)
        {
            if (randomInt == 1)
            {
                Console.WriteLine(_prompt1);
            }
        
            else if (randomInt == 2)
            {
                Console.WriteLine(_prompt2);
            }

            else if (randomInt == 3)
            {
                Console.WriteLine(_prompt3);
            }

            else if (randomInt == 4)
            {
                Console.WriteLine(_prompt4);
            }

            else if (randomInt == 5)
            {
                Console.WriteLine(_prompt5);
            }

            else if (randomInt == 6)
            {
                Console.WriteLine(_prompt6);
            }
        }
        
    }
        

        
}



