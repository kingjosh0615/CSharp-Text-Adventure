using System;

namespace DnD_Text_Adventure
{
    class Program
    {
        static bool QuestionConfirmationStopper = true;
        static void Main(string[] args)
        {
            Random rand = new Random();
            CharacterCreator PlayersCharacter = new CharacterCreator();
            CharacterCreator AiCharacterOne = new CharacterCreator();
            CharacterCreator AiCharacterTwo = new CharacterCreator();
            string tempPlayerInput;
            string tempDoubleChoiceSwitch;

            Console.WriteLine("You are going over to friend's house to play Dungeons and Dragons. You need to make you character for the campaign before you can play.");
            Console.WriteLine("Input your character's name.");
            PlayersCharacter.characterName = Console.ReadLine();
            Console.WriteLine("Now you need to pick you class. Your friends already picked most of the classes so now you can choose rouge or cleric.");
            tempPlayerInput = Console.ReadLine();
            PlayersCharacter.characterClass = DoubleQuestionConfirmation(tempPlayerInput, "rouge", "cleric");
            Console.WriteLine("Time to choose your race. Would you like to be an elf, dwarf, or human?");
            tempPlayerInput = Console.ReadLine();
            PlayersCharacter.characterRace = TripleQuestionConfirmation(tempPlayerInput, "elf", "dwarf", "human");
            Console.WriteLine("What would you like as a sidearm, sword, dagger, or blunderbuss?");
            tempPlayerInput = Console.ReadLine();
            PlayersCharacter.sideArm = TripleQuestionConfirmation(tempPlayerInput, "sword", "dagger", "blunderbuss");

            AiCharacterOne.characterClass = "mage";
            AiCharacterTwo.characterClass = "paladin";
            AiCharacterOne.characterName = "Eric";
            AiCharacterTwo.characterName = "Ben";
            AiCharacterOne.characterRace = "Elf";
            AiCharacterTwo.characterRace = "Dwarf";
            AiCharacterOne.sideArm = "sword";
            AiCharacterTwo.sideArm = "warhammer";

            Console.WriteLine($"Alright so you are a {PlayersCharacter.characterRace} {PlayersCharacter.characterClass} named {PlayersCharacter.characterName}. Sounds like a pretty good build to me.");
            Console.WriteLine($"You");




        }
        public static string DoubleQuestionConfirmation(string userInput, string optionOne, string optionTwo)
        {
            while (QuestionConfirmationStopper == true)
            {
                if (userInput.ToLower() == optionOne)
                {
                    QuestionConfirmationStopper = false;
                    return optionOne;
                }
                else if (userInput.ToLower() == optionTwo)
                {
                    QuestionConfirmationStopper = false;
                    return optionTwo;
                }
                else
                {
                    
                    Console.WriteLine("Please input a valid answer.");
                    QuestionConfirmationStopper = true;
                    
                }
            }
            return "c";
        }
        public static string TripleQuestionConfirmation(string userInput, string optionOne, string optionTwo, string optionThree)
        {
            while (QuestionConfirmationStopper == true)
            {
                if (userInput.ToLower() == optionOne)
                {
                    QuestionConfirmationStopper = false;
                    return optionOne;
                }
                else if (userInput.ToLower() == optionTwo)
                {
                    QuestionConfirmationStopper = false;
                    return optionTwo;
                }
                else if (userInput.ToLower() == optionThree)
                {
                    QuestionConfirmationStopper = false;
                    return optionThree;
                }
                else
                {

                    Console.WriteLine("Please input a valid answer.");
                    QuestionConfirmationStopper = true;

                }
            }
            return "c";
        }
    }
}
