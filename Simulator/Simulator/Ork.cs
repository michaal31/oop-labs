using System;

namespace Simulator
{
    public class Orc : Creature
    {
        private int _huntCount = 0;
        private int _rage;

        public int Rage
        {
            get => _rage;
            private set => _rage = Validator.Limiter(value, 0, 100);
       
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
            if (_huntCount % 2 == 0)
                Rage++;
        }

        public override void SayHi()
        {
            Console.WriteLine($"Grr! I'm {Name} the Orc (lvl {Level}) — Rage: {Rage}");
        }

        
        public override int Power => 7 * Level + 3 * Rage;

        public override string Info => $"{Name} <{Level}>[{Rage}]";
    }
}