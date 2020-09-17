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
            PlayersCharacter.healthPoints = rand.Next(10, 20);
            PlayersCharacter.strength = rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7);
            PlayersCharacter.strengthMod = Convert.ToInt32(Math.Floor(Convert.ToDouble((PlayersCharacter.strength - 10) / 2)));
            PlayersCharacter.dexterity = rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7);
            PlayersCharacter.dexterityMod = Convert.ToInt32(Math.Floor(Convert.ToDouble((PlayersCharacter.strength - 10) / 2)));
            PlayersCharacter.constitution = rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7);
            PlayersCharacter.constitutionMod = Convert.ToInt32(Math.Floor(Convert.ToDouble((PlayersCharacter.strength - 10) / 2)));
            PlayersCharacter.intelligence = rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7);
            PlayersCharacter.intelligenceMod = Convert.ToInt32(Math.Floor(Convert.ToDouble((PlayersCharacter.strength - 10) / 2)));
            PlayersCharacter.wisdom = rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7);
            PlayersCharacter.wisdomMod = Convert.ToInt32(Math.Floor(Convert.ToDouble((PlayersCharacter.strength - 10) / 2)));
            PlayersCharacter.charisma = rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7);
            PlayersCharacter.charismaMod = Convert.ToInt32(Math.Floor(Convert.ToDouble((PlayersCharacter.strength - 10) / 2)));
            PlayersCharacter.initativeModifier = PlayersCharacter.dexterityMod;

            CharacterCreator AiCharacterOne = new CharacterCreator();
            PlayersCharacter.healthPoints = rand.Next(10, 20);
            CharacterCreator AiCharacterTwo = new CharacterCreator();
            PlayersCharacter.healthPoints = rand.Next(10, 20);
            string tempPlayerInput;
            string tempDoubleChoiceSwitch;

            Console.WriteLine("You are going over to friend's house to play Dungeons and Dragons. You need to make you character for the campaign before you can play.");
            Console.WriteLine("Input your character's name.");
            PlayersCharacter.characterName = Console.ReadLine();
            Console.WriteLine("Now you need to pick you class. Your friends already picked most of the classes so now you can choose rouge or cleric.");
            tempPlayerInput = Console.ReadLine();
            PlayersCharacter.characterClass = DoubleQuestionConfirmation(tempPlayerInput, "Rouge", "Cleric");
            Console.WriteLine("Time to choose your race. Would you like to be an elf, dwarf, or human?");
            tempPlayerInput = Console.ReadLine();
            PlayersCharacter.characterRace = TripleQuestionConfirmation(tempPlayerInput, "Elf", "Dwarf", "Human");
            Console.WriteLine("What would you like as a sidearm, sword, dagger, or blunderbuss?");
            tempPlayerInput = Console.ReadLine();
            PlayersCharacter.sideArm = TripleQuestionConfirmation(tempPlayerInput, "sword", "dagger", "blunderbuss");

            AiCharacterOne.characterClass = "Mage";
            AiCharacterTwo.characterClass = "Paladin";
            AiCharacterOne.characterName = "Eric";
            AiCharacterTwo.characterName = "Ben";
            AiCharacterOne.characterRace = "Elf";
            AiCharacterTwo.characterRace = "Dwarf";
            AiCharacterOne.sideArm = "sword";
            AiCharacterTwo.sideArm = "warhammer";

            Console.WriteLine($"Alright so you are a {PlayersCharacter.characterRace} {PlayersCharacter.characterClass} named {PlayersCharacter.characterName}. Sounds like a pretty good build to me.");
            Console.WriteLine($"Your friends also made characters! They made a {AiCharacterOne.characterRace} {AiCharacterOne.characterClass} named {AiCharacterOne.characterName} and a {AiCharacterTwo.characterRace} {AiCharacterTwo.characterClass} named {AiCharacterTwo.characterName}.");




        }
        public static string DoubleQuestionConfirmation(string userInput, string optionOne, string optionTwo)
        {
            while (QuestionConfirmationStopper == true)
            {
                if (userInput.ToLower() == optionOne.ToLower())
                {
                    QuestionConfirmationStopper = false;
                    return optionOne;
                }
                else if (userInput.ToLower() == optionTwo.ToLower())
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
                if (userInput.ToLower() == optionOne.ToLower())
                {
                    QuestionConfirmationStopper = false;
                    return optionOne;
                }
                else if (userInput.ToLower() == optionTwo.ToLower())
                {
                    QuestionConfirmationStopper = false;
                    return optionTwo;
                }
                else if (userInput.ToLower() == optionThree.ToLower())
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
        public static void EnemyEncounter()
        {
            
        }
    }
}
