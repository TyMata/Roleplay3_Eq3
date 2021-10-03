using System;

namespace Roleplay_Prog.Library
{
    public class Orco : ICharacter
    {
        private string nombre;
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                if(!String.IsNullOrWhiteSpace(value))
                {
                    this.nombre = value;
                }
            }
        }
        private int vida = 130;
        public int Vida
        {
            get
            {
                return this.vida;
            }
            set
            {
                if(value >=0)
                {
                    this.vida = value;
                }
                else
                {
                    this.vida = 0;
                }
            }
        }
        public IItemAtaque ItemOf{get;set;}
        public IItemDefensa ItemDef{get;set;}

        public Orco(string nombre)
        {
            this.Nombre = nombre;
        }

        public void CambiarItemOf(IItemAtaque mazo)
        {
            this.ItemOf = mazo;
        }

        public void QuitarItemOf()
        {
            this.ItemOf = null;
        }
        public void CambiarItemDef(IItemDefensa yelmo)
        {
            this.ItemDef = yelmo;
        }

        public void QuitarItemDef()
        {
            this.ItemDef = null;
        }

        public int GetAtaque()
        {
            return this.ItemOf.Ataque;
        }

        public void Atacar(ICharacter chara)
        {
            if(chara.ItemDef.Defensa < this.GetAtaque() )
            {
                int danio = this.GetAtaque() - chara.ItemDef.Defensa;
                chara.Vida -= danio;
            }
        }

        public void Curarse()
        {
            this.Vida = 130;
        }
    }
}