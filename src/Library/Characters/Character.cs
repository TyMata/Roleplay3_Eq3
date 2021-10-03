using System.Collections.Generic;
using System;

namespace Roleplay_Prog.Library
{
    public class Character
    {
        protected string nombre;
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
        protected int vida;
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
       protected int vp;
       public int VP
       {
            get
            {
                return this.vp;
            }
            set
            {
                if(value >=0)
                {
                    this.vp = value;
                }
                else
                {
                    this.vp = 0;
                }
            }
        }
        public ItemDefensa ItemDef{get;set;}

        protected Character(string name)
        {
            this.Nombre = name;
        }

        
        public void CambiarItemDef(ItemDefensa escudo)
        {
            this.ItemDef = escudo;
        }

        public void QuitarItemDef()
        {
            this.ItemDef = null;
        }
    }
}