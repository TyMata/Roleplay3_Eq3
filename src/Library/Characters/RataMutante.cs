using System;

namespace Roleplay_Prog.Library
{
    public class RataMutante : Enemy
    {
        public RataMutante(string nombre) : base(nombre)
        {
            this.Vida = 30;
            this.VP = 1;
        }
    }
}