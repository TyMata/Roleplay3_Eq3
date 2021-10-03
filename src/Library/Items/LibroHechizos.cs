using System.Collections.Generic;

namespace Roleplay_Prog.Library
{
    public class LibroHechizos : IItemAtaque, IItemDefensa
    {
        public List<Spell> Spells = new List<Spell>();
        private int ataque;
        public int Ataque
        {
            get
            {
                int value = 0;
                foreach (Spell spell in this.Spells)
                {
                    value += spell.Ataque;
                }
                return value;
            }
            set
            {
                if(value >= 0)
                {
                    this.ataque = value;
                }
                else
                {
                    this.ataque = 0;
                }
            }
        }
        private int defensa;
        public int Defensa
        {
            get
            {
                int value = 0;
                foreach (Spell spell in this.Spells)
                {
                    value += spell.Defensa;
                }
                return value;
            }
            set
            {
                if(value >=0)
                {
                    this.defensa = value;
                }
                else
                {
                    this.defensa = 0;
                }
            }
        }
        public void AniadirSpell(Spell spell)
        {
            this.Spells.Add(spell);
        }
    }
}