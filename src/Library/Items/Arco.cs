using System;

namespace Roleplay_Prog.Library
{
    public class Arco : IItemAtaque
    {
        private int ataque;
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
        
        public Arco(int ataque)
        {
            this.Ataque = ataque;
        }
    }
}