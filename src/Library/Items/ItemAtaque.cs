using System;

namespace Roleplay_Prog.Library
{
    public class ItemAtaque
    {

        protected int ataque;
        public int Ataque
        {
            get
            {
                return this.ataque;
            }
            set
            {
                if(value >=0)
                {
                    this.ataque = value;
                }
                else
                {
                    this.ataque = 0;
                } 
            }
        }

        protected ItemAtaque(int ataque)
        {
            this.Ataque = ataque;
        }
    }
}