using System.Collections.Generic;
using System;

namespace Roleplay_Prog.Library
{
    public class Enemy : Character
    {public ItemAtaque ItemOf{get;set;}

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

        public void Atacar(IHeroes chara)
        {
            if(chara.ItemDef.Defensa < this.GetAtaque() )
            {
                int danio = this.GetAtaque() - chara.ItemDef.Defensa;
                chara.Vida -= danio;
            }
        }

        protected Enemy(string nombre): base (nombre)
        {
            
        }
    }
}