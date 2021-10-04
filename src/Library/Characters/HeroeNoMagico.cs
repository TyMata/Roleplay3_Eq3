using System;

namespace Roleplay_Prog.Library
{
    public abstract class HeroeNoMagico : Character, IHeroes
    {
        public ItemAtaque ItemOf{get;set;}

        public void CambiarItemOf(ItemAtaque cuchillo)
        {
            this.ItemOf = cuchillo;
        }

        public void QuitarItemOf()
        {
            this.ItemOf = null;
        }

        public int GetAtaque()
        {
            return this.ItemOf.Ataque;
        }

        public void Atacar(Character chara)
        {
            if(chara.ItemDef.Defensa < this.GetAtaque() )
            {
                int danio = this.GetAtaque() - chara.ItemDef.Defensa;
                chara.Vida -= danio;
            }
        }

        public abstract void Curarse();
        protected HeroeNoMagico(string nombre): base (nombre)
        {
            this.VP = 0;
        }
    }
}