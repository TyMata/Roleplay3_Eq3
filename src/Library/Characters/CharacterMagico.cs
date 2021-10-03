using System;
using System.Collections.Generic;

namespace Roleplay_Prog.Library
{
    public class CharacterMagico : Character
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
        protected CharacterMagico(string nombre): base (nombre)
        {
            
        }
    }
}