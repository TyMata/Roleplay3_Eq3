using System;

namespace Roleplay_Prog.Library
{
    public class Cuchillo : IItemAtaque

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
            
            public Cuchillo(int ataque)
            {
                this.Ataque = ataque;
            }
         }

}  