using System;
using System.Collections.Generic;

namespace Roleplay_Prog.Library
{
    public abstract class HeroeMagico : Character, IHeroes
    {
        public LibroHechizos ItemOf{get;set;}

        public void CambiarItemOf(LibroHechizos cuchillo)
        {
            this.ItemOf = cuchillo;
        }

        public void QuitarItemOf()
        {
            this.ItemOf = null;
        }

        public int GetAtaque()
        {
            return this.ItemOf.GetAtaque();
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
        protected HeroeMagico(string nombre): base (nombre)
        {
           this.VP = 0;
        }
    }
}