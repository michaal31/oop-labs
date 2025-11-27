using System;

namespace Simulator
{
    public class Orc : Creature
    {
        private int _huntCount = 0;
        private int _rage = 0;

        public int Rage
        {
            get => _rage;
            private set
            {
                if (value < 0) value = 0;
                if (value > 10) value = 10;
                _rage = value;
            }
        }

        public Orc() : base() { }

        public Orc(string name = "Unknown", int level = 1, int rage = 0)
            : base(name, level)
        {
            Rage = rage;
        }

        // co drugie Hunt() zwiększa Rage (do max 10)
        public void Hunt()
        {
            _huntCount++;
            Console.WriteLine($"{Name} hunts. (hunt #{_huntCount})");
            if (_huntCount % 2 == 0)
            {
                if (Rage < 10)
                {
                    Rage++;
                    Console.WriteLine($"{Name}'s rage increased to {Rage}!");
                }
            }
        }

        public override void SayHi()
        {
            Console.WriteLine($"Grr! I'm {Name} the Orc (lvl {Level}) — Rage: {Rage}");
        }

        
        public override int Power => 7 * Level + 3 * Rage;

        public override string Info => $"{Name} <{Level}>[{Rage}]";
    }
}