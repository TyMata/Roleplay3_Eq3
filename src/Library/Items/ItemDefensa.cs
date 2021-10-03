using System;

namespace Roleplay_Prog.Library
{
    public class ItemDefensa
    {

        protected int defensa;
        public int Defensa
        {
            get
            {
                return this.defensa;
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

        protected ItemDefensa(int defensa)
        {
            this.Defensa = defensa;
        }
    }
}