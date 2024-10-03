namespace ExploringVariables_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            string heroFirstName = "Max";
            string heroLastName = "Sigrest";
            string heroFullName;
            string villainTitle = "Lord of Darkness";
            string minionTitle = "Background Grunt";
            string villainName;
            string minion1Name;
            string minion2Name;

            int heroHealth = 100;
            int heroStrength = 50;
            int bossHealth = 100;
            int bossStrength = 25;
            int minion1Health = 50;
            int minion2Health = 50;
            int minionStrength = 5;

            //Begin Coding Instructions
            heroFullName = heroFirstName + " " + heroLastName;

            Console.Write("Behold the legendary hero of programming, whose name is: ");
            Console.WriteLine(heroFullName);

            villainName = "Steve";
            minion1Name = "Joe";
            minion2Name = "Shmoe";

            Console.WriteLine(heroFullName + "'s arch rival is" + villainName + " the " + villainTitle);
            Console.WriteLine(villainName + " the " + villainTitle + " is helped out by: " + minionTitle + " " + minion1Name + " and " + minionTitle + " " + minion2Name);

            Console.WriteLine();
            Console.WriteLine("The hero and the villains enter the arena!");
            Console.WriteLine("Hero's health: " + heroHealth);
            Console.WriteLine("Villain's health: " + bossHealth);
            Console.WriteLine("Minion 1's health: " + minion1Health);
            Console.WriteLine("Minion 2's health: " + minion2Health);

            Console.WriteLine(villainName + " " + villainTitle + " attacks " + heroFullName);
            Console.WriteLine(villainName + " " + villainTitle + " deals " + bossStrength + " damage!");
            heroHealth = heroHealth - bossStrength;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");
            Console.WriteLine("The evil minions now attack!");
            Console.WriteLine(minion1Name + " deals " + minionStrength + " damage!");
            heroHealth -= minionStrength;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");
            Console.WriteLine(minion2Name + " deals " + minionStrength + " damage!");
            heroHealth -= minionStrength;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");

            Console.WriteLine(heroFullName + " attacks each villain for " + heroStrength + " damage!");
            bossHealth -= heroStrength;
            minion1Health -= heroStrength;
            minion2Health -= heroStrength;
            Console.WriteLine(villainName + " " + villainTitle + " now has " + bossHealth + " health!");
            Console.WriteLine(minionTitle + " " + minion1Name + " now has " + minion1Health + " health!");
            Console.WriteLine(minionTitle + " " + minion2Name + " now has " + minion2Health + " health!");
            Console.WriteLine(minion1Name + " and " + minion2Name + " have been defeated!");

            Console.WriteLine(heroFullName + " has " + heroHealth + "health");
            Console.WriteLine(heroFullName + " eats an apple to restore health!");
            heroHealth++;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");

            Console.WriteLine(villainName + " " + villainTitle + " attacks " + heroFullName);
            heroHealth -= bossStrength;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");
            Console.WriteLine("The remaining fighters continue the fight!");
            Console.WriteLine("Hero's health: " + heroHealth);
            Console.WriteLine("Boss's health: " + bossHealth);
            Console.WriteLine(villainName + " " + villainTitle + " attacks " + heroFullName);
            Console.WriteLine(villainName + " " + villainTitle + " deals " + bossStrength + " damage!");
            heroHealth -= bossStrength;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");
            Console.WriteLine(heroFullName + " now attacks " + villainName + " " + villainTitle + " for " + heroStrength + " damage!");
            bossHealth -= heroStrength;
            Console.WriteLine(villainName + " " + villainTitle + " now has " + bossHealth + " health!");

            Console.WriteLine(heroFullName + " is victorious!");
            Console.WriteLine("Wealth, glory, and straight A's to the winner!");
        }
    }
}