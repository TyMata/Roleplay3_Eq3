using System;

namespace Roleplay_Prog.Library
{
    public class Esqueleto : Enemy
    {
        public Esqueleto(string nombre) : base(nombre)
        {
            this.Vida = 50;
            this.VP = 3;
        }
    }       
}