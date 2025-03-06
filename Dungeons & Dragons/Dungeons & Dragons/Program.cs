using System.Threading.Channels;

namespace Dungeons___Dragons
{
    class startMenu
    {
        public string welcome()
        {
            string dungeonName = "Welcome to Dungeons & Dragons: The Dungeon of Mortis";
            return $"{dungeonName}";
        }
    }

    class heroClasses
    {
        public string Name { get; set; }
        public int Health { get; set; }
       
        public heroClasses(string name, int health, int damage)
        {
            Name = name;
            Health = health;
        }
        public virtual int Attac1k() { return 0; }
        public virtual int Attack2() { return 0; }
        public virtual int Attack3() { return 0; }
    }

    class Mage : heroClasses
    {
        public Mage() : base("Mage", 90) { }
        public override int Attack1() { return }
    }

    class enemyMonsters
    {
        
    }

    class diceRoll
    {
        private static Random random = new Random();
        public static int Roll(int sides)
        {
            return random.Next(1, sides + 1); //Kald frem med diceRoll.Roll(6)
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
