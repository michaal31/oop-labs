using System;

namespace Simulator
{
    public class Elf : Creature
    {
        private int _singCount = 0;
        private int _agility = 0;

        public int Agility
        {
            get => _agility;
            private set
            {
                if (value < 0) value = 0;
                if (value > 10) value = 10;
                _agility = value;
            }
        }

        
        public Elf() : base() { }

        
        public Elf(string name = "Unknown", int level = 1, int agility = 0)
            : base(name, level)
        {
            Agility = agility;
        }

        // co trzeci Sing() zwiększa Agility (do max 10)
        public void Sing()
        {
            _singCount++;
            Console.WriteLine($"{Name} sings. (sing #{_singCount})");
            if (_singCount % 3 == 0)
            {
                if (Agility < 10)
                {
                    Agility++;
                    Console.WriteLine($"{Name}'s agility increased to {Agility}!");
                }
            }
        }

        
        public override void SayHi()
        {
            Console.WriteLine($"Hi, I'm {Name} the Elf (lvl {Level}) — Agility: {Agility}");
        }

        
        public override int Power => 8 * Level + 2 * Agility;

        
        public override string Info => $"{Name} <{Level}>[{Agility}]";
    }
}
