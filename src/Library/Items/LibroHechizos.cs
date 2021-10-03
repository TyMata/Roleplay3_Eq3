using System.Collections.Generic;

namespace Roleplay_Prog.Library
{
    public class LibroHechizos : IItemMagico
    {
        public List<Spell> Spells = new List<Spell>();

        public int GetAtaque()
        {
            int value = 0;
            foreach (Spell item in Spells)
            {
                value = item.Ataque;
            }

            return value;
        }
        public LibroHechizos()
        {
        }

        public void AniadirSpell(Spell spell)
        {
            this.Spells.Add(spell);
        }
    }
}