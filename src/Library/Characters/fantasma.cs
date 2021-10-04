using System;

namespace Roleplay_Prog.Library
{
    public class Fantasma : Enemy
    {
        public Fantasma(string nombre) : base(nombre)
        {
            this.Vida = 25;
            this.VP = 2;
        }
    }
}