using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeons___Dragons.Charecter
{
    public class Character_stats
    {
        public string CharacterName { get; set; }
        public char ForceChoice
        {
            get { return _forceChoice; }
            set
            {
                _forceChoice = value;
                SetCharacterTitle();
            }
        }
        private char _forceChoice;
        public int CharacterLevel { get; set; } = 0;
        public string CharacterTitle { get; private set; }
        public int MaxLife { get; set; } = 100;
        public int CurrentLife { get; set; } = 100;
        public int MaxForceEnergy { get; set; } = 20;
        public int CurrentForceEnergy { get; set; } = 20;
        public int StrengthPoints { get; set; } = 10;
        public int DexterityPoints { get; set; } = 10;
        public int AgilityPoints { get; set; } = 10;
        public int DefencePoints { get; set; } = 0;
        public int CurrentXP { get; set; } = 0;
        public int MaxXP { get; set; } = 100;

        private void SetCharacterTitle()
        {
            if (ForceChoice == 'D')
            {
                Dark_side darkSide = new Dark_side();
                CharacterTitle = darkSide.GetTitle(CharacterLevel);
            }
            else if (ForceChoice == 'L')
            {
                Light_side lightSide = new Light_side();
                CharacterTitle = lightSide.GetTitle(CharacterLevel);
            }
        }
    }
}

/*
namespace DD
{

    // Superclass der repræsenterer en karakter med de fælles attributter og metoder
    class Character
    {
    }

    // Subclass der repræsenterer en karakter fra den mørke side med dens egne attributter og metoder
    class DarkSideCharacter : Character
    {
    }

    // Subclass der repræsenterer en karakter fra den lyse side med dens egne attributter og metoder
    class LightSideCharacter : Character
    {
    }

    // Singleton pattern er et design pattern der sikrer at der kun kan være én instans af en klasse.
    // Den indeholder den karakter som spilleren har valgt at spille som.
    class Player
    {
        private static Player? _instance;
        private static readonly object _lock = new object();

        public Character Character { get; private set; }

        public static Player Instance(Char side = 'D')
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new Player(side);
                }
                return _instance;
            }
        }

        private Player(Char side)
        {
            if (side == 'D')
            {
                Character = new DarkSideCharacter();
            }
            else
            {
                Character = new LightSideCharacter();
            }
        }
    }

    class Progarm
    {
        Player? player;

        public void Main()
        {
            Console.WriteLine("Indtast om du vil være på den lyse eller mørke side (L/D): ");
            Char side = Console.ReadKey().KeyChar;
            Player player = Player.Instance(side); // Singleton pattern betyder at der kun kan være én instans af Player-klassen. Data i klassen har samme værdi uanset hvor det bliver kaldt fra.
        }
    }
}
*/
